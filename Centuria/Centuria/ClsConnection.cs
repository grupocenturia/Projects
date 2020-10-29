using System;
using System.Data;
using System.Data.SqlClient;

namespace Centuria
{
    class ClsConnection
    {
        private static SqlCommand FxSqlConnection()
        {
            SqlConnection ObjSqlConnection = new SqlConnection();

            SqlCommand ObjSqlCommand = new SqlCommand();

            SqlConnectionStringBuilder ObjSqlConnectionString = FxSqlConnectionString();

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

        private static SqlConnectionStringBuilder FxSqlConnectionString()
        {
            SqlConnectionStringBuilder ObjSqlConnectionString = new SqlConnectionStringBuilder
            {
                DataSource = ClsVariables.gServer,
                InitialCatalog = "CNTDB00",
                UserID = "CenturiaUser",
                Password = "GrupoCenturia2020--",
                IntegratedSecurity = false,
                MaxPoolSize = 500
            };

            return ObjSqlConnectionString;
        }

        internal static DataTable FxSqlExecute(string pSchema, string pStoredProcedure)
        {
            object[][] lParameters = new object[2][];

            DataTable ObjDt = FxSqlExecute(pSchema, pStoredProcedure, lParameters);

            return ObjDt;
        }

        internal static DataTable FxSqlExecute(string pSchema, string pStoredProcedure, object[][] pParameters)
        {
            DataTable ObjDt = new DataTable();

            using (SqlDataAdapter ObjSqlDa = new SqlDataAdapter())
            {
                using (SqlCommand ObjSqlCommand = FxSqlConnection())
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

                    if(ObjSqlCommand != null)
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
    }
}
