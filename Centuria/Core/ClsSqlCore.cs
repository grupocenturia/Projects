using System.Data;
using System.Drawing;
using System.IO;

namespace Core
{
    public class ClsSqlCore
    {
        static readonly string lSchema = "Core";

        internal static Bitmap FxSqlImage(string pDatabase, string pSchema, string pStoredProcedure, object[][] pParameters)
        {
            DataTable ObjDt = ClsConnection.FxSqlExecute(pDatabase, pSchema, pStoredProcedure, pParameters);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    byte[] ObjBuffer = (byte[])ObjDt.Rows[0][0];

                    MemoryStream ObjStream = new MemoryStream(ObjBuffer);

                    Bitmap ObjImage = new Bitmap(ObjStream);

                    ObjStream.Close();
                    ObjStream.Dispose();

                    return ObjImage;
                }
                else
                {
                    ObjDt.Dispose();

                    return null;
                }
            }
            else
            {
                return null;
            }
        }


      
        public static DataTable Fx_sel_tblLanguage(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblLanguage", lParameters);

            return ObjDt;
        }

        public static DataTable Fx_sel_tblLanguage_detail(long pProfileId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "ProfileId" };
            lParameters[1] = new object[] { pProfileId };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblLanguage_detail", lParameters);

            return ObjDt;
        }

        public static long Fx_ins_tblLanguage(string pName)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Name" };
            lParameters[1] = new object[] { pName };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_ins_tblLanguage", lParameters);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    try
                    {
                        lId = long.Parse(ObjDt.Rows[0][0].ToString());
                    }
                    catch
                    {
                        lId = 0;
                    }
                }

                ObjDt.Dispose();
            }

            if (lId == 0)
            {
                ClsFunctions.FxMessage(1, "Registro no pudo ser guardado");
            }
            else
            {
                ClsFunctions.FxMessage("Proceso concluido");
            }

            return lId;
        }

        public static long Fx_upt_tblLanguage(long pLanguageId, string pName, bool pEnabled)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "LanguageId", "Name", "Enabled" };
            lParameters[1] = new object[] { pLanguageId, pName, pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_upt_tblLanguage", lParameters);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    try
                    {
                        lId = long.Parse(ObjDt.Rows[0][0].ToString());
                    }
                    catch
                    {
                        lId = 0;
                    }
                }

                ObjDt.Dispose();
            }

            if (lId == 0)
            {
                ClsFunctions.FxMessage(1, "Registro no pudo ser guardado");
            }
            else
            {
                ClsFunctions.FxMessage("Proceso concluido");
            }

            return lId;
        }
    }


}
