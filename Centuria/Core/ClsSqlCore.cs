using System.Data;
using System.Drawing;
using System.IO;

namespace Core
{
    public class ClsSqlCore
    {
        static readonly string lSchema = "Core";

  
        public static DataTable Fx_sel_tblLanguage(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblLanguage", lParameters);

            return ObjDt;
        }

        public static DataTable Fx_sel_tblLanguage_detail(long pLanguageId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "LanguageId" };
            lParameters[1] = new object[] { pLanguageId };

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
