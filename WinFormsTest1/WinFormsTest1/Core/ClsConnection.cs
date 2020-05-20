using System;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsTest1
{
    class ClsConnection
    {
        private static SqlCommand FxSqlConnection()
        {
            SqlConnection ObjSqlCn = new SqlConnection();

            SqlCommand ObjSqlCm = new SqlCommand();

            SqlConnectionStringBuilder ObjSqlCs = FxSqlConnectionStringBuilder();

            ObjSqlCn.ConnectionString = ObjSqlCs.ConnectionString;

            ObjSqlCm.Connection = ObjSqlCn;

            try
            {
                ObjSqlCn.Open();
            }
            catch
            {
                ObjSqlCm = null;

                ClsFunctions.FxMessage(1, "No pudo conectarse con el servidor");

                ClsFunctions.FxExit();
            }

            ObjSqlCs = null;

            return ObjSqlCm;
        }

        private static SqlConnectionStringBuilder FxSqlConnectionStringBuilder()
        {
            SqlConnectionStringBuilder ObjSqlCs = new SqlConnectionStringBuilder
            {
                DataSource = ClsVariables.gServer,
                InitialCatalog = "TestDB",
                UserID = "usrTestDB",
                Password = "123456",
                IntegratedSecurity = false,
                MaxPoolSize = 500
            };

            return ObjSqlCs;
        }

        internal static DataTable FxSqlExecute(string pSp)
        {
            object[][] lParameters = new object[2][];

            DataTable ObjSqlDt = FxSqlExecute(pSp, lParameters);

            return ObjSqlDt;
        }

        internal static DataTable FxSqlExecute(string pSp, object[][] pParameters)
        {
            SqlDataAdapter ObjSqlDa = new SqlDataAdapter();

            DataTable ObjSqlDt = new DataTable();

            SqlCommand ObjSqlCm = FxSqlConnection();

            if (ObjSqlCm != null)
            {
                if (pParameters[0] != null)
                {
                    FxSqlParameters(ObjSqlCm, pParameters);
                }

                ObjSqlCm.CommandType = CommandType.StoredProcedure;

                ObjSqlCm.CommandText = pSp;

                ObjSqlDa.SelectCommand = ObjSqlCm;

                try
                {
                    ObjSqlDa.Fill(ObjSqlDt);
                }
                catch
                {
                    ObjSqlDt = null;
                }
            }

            ObjSqlCm.Connection.Close();

            ObjSqlDa.Dispose();

            ObjSqlCm.Dispose();

            return ObjSqlDt;
        }

        private static SqlCommand FxSqlParameters(SqlCommand pSqlCm, object[][] pParameters)
        {
            SqlCommand ObjSqlCm = pSqlCm;

            for (int lCounter = 0; lCounter < pParameters[0].Length; lCounter++)
            {
                string lParameter = "@" + pParameters[0][lCounter];
                var lValue = pParameters[1][lCounter];
                var lType = lValue.GetType();

                if (lType == typeof(int) || lType == typeof(long))
                {
                    ObjSqlCm.Parameters.AddWithValue(lParameter, lValue).SqlDbType = SqlDbType.Int;
                }
                else if (lType == typeof(double))
                {
                    ObjSqlCm.Parameters.AddWithValue(lParameter, lValue).SqlDbType = SqlDbType.Float;
                }
                else if (lType == typeof(bool))
                {
                    ObjSqlCm.Parameters.AddWithValue(lParameter, lValue).SqlDbType = SqlDbType.Bit;
                }
                else if (lType == typeof(DateTime))
                {
                    ObjSqlCm.Parameters.AddWithValue(lParameter, lValue).SqlDbType = SqlDbType.DateTime;
                }
                else
                {
                    ObjSqlCm.Parameters.AddWithValue(lParameter, lValue);
                }
            }

            return ObjSqlCm;
        }
    }
}
