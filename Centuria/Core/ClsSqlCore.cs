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

        public static DataTable Fx_sel_tblDataType(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblDataType", lParameters);

            return ObjDt;
        }

        public static DataTable Fx_sel_tblDataType_detail(long pDataTypeId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "DataTypeId" };
            lParameters[1] = new object[] { pDataTypeId };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblDataType_detail", lParameters);

            return ObjDt;
        }

        public static long Fx_ins_tblDataType(string pName)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Name" };
            lParameters[1] = new object[] { pName };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_ins_tblDataType", lParameters);

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

        public static long Fx_upt_tblDataType(long pDataTypeId, string pName, bool pEnabled)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "DataTypeId", "Name", "Enabled" };
            lParameters[1] = new object[] { pDataTypeId, pName, pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_upt_tblDataType", lParameters);

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

        public static DataTable Fx_sel_tblCountry(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblCountry", lParameters);

            return ObjDt;
        }

        public static DataTable Fx_sel_tblCountry_detail(long pCountryId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "CountryId" };
            lParameters[1] = new object[] { pCountryId };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblCountry_detail", lParameters);

            return ObjDt;
        }

        public static long Fx_ins_tblCountry(string pName, string pIsoCode)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Name", "IsoCode" };
            lParameters[1] = new object[] { pName , pIsoCode };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_ins_tblCountry", lParameters);

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

        public static long Fx_upt_tblCountry(long pCountryId, string pName, string pIsoCode, bool pEnabled)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "CountryId", "Name", "IsoCode", "Enabled" };
            lParameters[1] = new object[] { pCountryId, pName, pIsoCode, pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_upt_tblCountry", lParameters);

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

        public static DataTable Fx_sel_tblCurrency(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblCurrency", lParameters);

            return ObjDt;
        }

        public static DataTable Fx_sel_tblCurrency_detail(long pCurrencyId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "CurrencyId" };
            lParameters[1] = new object[] { pCurrencyId };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblCurrency_detail", lParameters);

            return ObjDt;
        }

        public static long Fx_ins_tblCurrency(string pName,  string pIsoCode, string pSymbol)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Name", "IsoCode", "Symbol" };
            lParameters[1] = new object[] { pName, pIsoCode,  pSymbol };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_ins_tblCurrency", lParameters);

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

        public static long Fx_upt_tblCurrency(long pCurrencyId, string pName, string pIsoCode, string pSymbol, bool pEnabled)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "CurrencyId", "Name", "IsoCode", "Symbol", "Enabled" };
            lParameters[1] = new object[] { pCurrencyId, pName, pIsoCode, pSymbol, pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_upt_tblCurrency", lParameters);

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
