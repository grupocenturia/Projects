using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;

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

                //functions.fxMessage(1, "No pudo conectarse con el servidor");

                //functions.fxExit();
            }

            ObjSqlCs = null;

            return ObjSqlCm;
        }

        private static SqlConnectionStringBuilder FxSqlConnectionStringBuilder()
        {
            SqlConnectionStringBuilder ObjSqlCs = new SqlConnectionStringBuilder
            {
                DataSource = "localhost",
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

            //for (int lCounter = 0; lCounter < pParameters[0].Length; lCounter++)
            //{
            //    string lParameter = "@" + pParameters[0][lCounter];
            //    string lTtype = pParameters[1][lCounter];
            //    string lValue = pParameters[2][lCounter];

            //    switch (lTtype)
            //    {
            //        case "int":
            //            ObjSqlCm.Parameters.AddWithValue(lParameter, long.Parse(lValue)).SqlDbType = SqlDbType.Int;

            //            break;

            //        case "smallint":
            //            ObjSqlCm.Parameters.AddWithValue(lParameter, int.Parse(lValue)).SqlDbType = SqlDbType.SmallInt;

            //            break;

            //        case "tinyint":
            //            ObjSqlCm.Parameters.AddWithValue(lParameter, int.Parse(lValue)).SqlDbType = SqlDbType.TinyInt;

            //            break;

            //        case "bit":
            //            ObjSqlCm.Parameters.AddWithValue(lParameter, int.Parse(lValue)).SqlDbType = SqlDbType.Bit;

            //            break;

            //        case "numeric":
            //            ObjSqlCm.Parameters.AddWithValue(lParameter, double.Parse(lValue)).SqlDbType = SqlDbType.Float;

            //            break;

            //        //case "file":
            //        //    byte[] objBuffer = functions.fxConvertFileByte(lValue);

            //        //    if (objBuffer != null)
            //        //    {
            //        //        ObjSqlCm.Parameters.AddWithValue(lParameter, objBuffer).SqlDbType = SqlDbType.VarBinary;
            //        //    }
            //        //    else
            //        //    {
            //        //        ObjSqlCm.Parameters.AddWithValue(lParameter, DBNull.Value).SqlDbType = SqlDbType.VarBinary;
            //        //    }

            //        //    objBuffer = null;

            //        //    break;

            //        default: //varchar, datetime
            //            ObjSqlCm.Parameters.AddWithValue(lParameter, lValue);

            //            break;
            //    }
            //}

            return ObjSqlCm;
        }
    }
}
