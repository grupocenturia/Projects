﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace Core
{
    public class ClsConnection
    {
        private static SqlCommand FxSqlConnection(string pDatabase)
        {
            SqlConnection ObjSqlConnection = new SqlConnection();

            SqlCommand ObjSqlCommand = new SqlCommand();

            SqlConnectionStringBuilder ObjSqlConnectionString = FxSqlConnectionString(pDatabase);

            ObjSqlConnection.ConnectionString = ObjSqlConnectionString.ConnectionString;

            ObjSqlCommand.Connection = ObjSqlConnection;

            try
            {
                ObjSqlConnection.Open();
            }
            catch
            {
                ObjSqlCommand = null;

                ClsFunctions.FxMessage(1, "No pudo conectarse con el servidor");

                ClsFunctions.FxExit();
            }

            ObjSqlConnectionString.Clear();

            return ObjSqlCommand;
        }

        private static SqlConnectionStringBuilder FxSqlConnectionString(string pDatabase)
        {
            SqlConnectionStringBuilder ObjSqlConnectionString = new SqlConnectionStringBuilder
            {
                DataSource = ClsVariables.gServer,
                InitialCatalog = pDatabase,
                UserID = "CenturiaUser",
                Password = "GrupoCenturia2020--",
                IntegratedSecurity = false,
                MaxPoolSize = 500
            };

            return ObjSqlConnectionString;
        }

        internal static DataTable FxSqlExecute(string pDatabase, string pSchema, string pStoredProcedure)
        {
            object[][] lParameters = new object[2][];

            DataTable ObjDt = FxSqlExecute(pDatabase, pSchema, pStoredProcedure, lParameters);

            return ObjDt;
        }

        internal static DataTable FxSqlExecute(string pDatabase, string pSchema, string pStoredProcedure, object[][] pParameters)
        {
            DataTable ObjDt = new DataTable();

            using (SqlDataAdapter ObjSqlDa = new SqlDataAdapter())
            {
                using (SqlCommand ObjSqlCommand = FxSqlConnection(pDatabase))
                {
                    if (ObjSqlCommand != null)
                    {
                        if (pParameters[0] != null)
                        {
                            FxSqlParameters(ObjSqlCommand, pParameters);
                        }

                        ObjSqlCommand.CommandType = CommandType.StoredProcedure;

                        ObjSqlCommand.CommandText = pSchema + "." + pStoredProcedure;

                        ObjSqlDa.SelectCommand = ObjSqlCommand;

                        try
                        {
                            ObjSqlDa.Fill(ObjDt);
                        }
                        catch
                        {
                            ObjDt = null;

                            ClsFunctions.FxMessage(1, "Operación no fue completada");

                            ClsFunctions.FxExit();
                        }
                    }

                    if (ObjSqlCommand != null)
                    {
                        ObjSqlCommand.Connection.Close();
                    }
                }
            }

            return ObjDt;
        }

        private static void FxSqlParameters(SqlCommand pSqlCommand, object[][] pParameters)
        {
            for (int lCounter = 0; lCounter < pParameters[0].Length; lCounter++)
            {
                string lParameter = "@" + pParameters[0][lCounter];

                var lValue = pParameters[1][lCounter];
                var lType = lValue.GetType();

                if (lType == typeof(int) || lType == typeof(long))
                {
                    pSqlCommand.Parameters.AddWithValue(lParameter, lValue).SqlDbType = SqlDbType.Int;
                }
                else if (lType == typeof(double))
                {
                    pSqlCommand.Parameters.AddWithValue(lParameter, lValue).SqlDbType = SqlDbType.Float;
                }
                else if (lType == typeof(bool))
                {
                    pSqlCommand.Parameters.AddWithValue(lParameter, lValue).SqlDbType = SqlDbType.Bit;
                }
                else if (lType == typeof(DateTime))
                {
                    pSqlCommand.Parameters.AddWithValue(lParameter, lValue).SqlDbType = SqlDbType.DateTime;
                }
                else
                {
                    pSqlCommand.Parameters.AddWithValue(lParameter, lValue);
                }
            }
        }

        internal static DataTable FxSqlExecuteImage(string pDatabase, string pSchema, string pStoredProcedure, object[][] pParameters)
        {
            DataTable ObjDt = new DataTable();

            using (SqlDataAdapter ObjSqlDa = new SqlDataAdapter())
            {
                using (SqlCommand ObjSqlCommand = FxSqlConnection(pDatabase))
                {
                    if (ObjSqlCommand != null)
                    {
                        if (pParameters[0] != null)
                        {
                            FxSqlParametersImage(ObjSqlCommand, pParameters);
                        }

                        ObjSqlCommand.CommandType = CommandType.StoredProcedure;

                        ObjSqlCommand.CommandText = pSchema + "." + pStoredProcedure;

                        ObjSqlDa.SelectCommand = ObjSqlCommand;

                        try
                        {
                            ObjSqlDa.Fill(ObjDt);
                        }
                        catch
                        {
                            ObjDt = null;

                            ClsFunctions.FxMessage(1, "Operación no fue completada");

                            ClsFunctions.FxExit();
                        }
                    }

                    if (ObjSqlCommand != null)
                    {
                        ObjSqlCommand.Connection.Close();
                    }
                }
            }

            return ObjDt;
        }

        private static void FxSqlParametersImage(SqlCommand pSqlCommand, object[][] pParameters)
        {
            for (int lCounter = 0; lCounter < pParameters[0].Length; lCounter++)
            {
                string lParameter = "@" + pParameters[0][lCounter];

                var lValue = pParameters[1][lCounter];
                var lType = lValue.GetType();

                if (lType == typeof(long))
                {
                    pSqlCommand.Parameters.AddWithValue(lParameter, lValue).SqlDbType = SqlDbType.Int;
                }
                else
                {
                    byte[] ObjBuffer = ClsFunctions.FxConvertFileByte(lValue.ToString());

                    if (ObjBuffer != null)
                    {
                        pSqlCommand.Parameters.AddWithValue(lParameter, ObjBuffer).SqlDbType = SqlDbType.VarBinary;
                    }
                    else
                    {
                        pSqlCommand.Parameters.AddWithValue(lParameter, DBNull.Value).SqlDbType = SqlDbType.VarBinary;
                    }
                }
            }
        }

    }
}
