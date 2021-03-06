﻿using System.Data;
using System.Drawing;
using System.IO;

namespace Core
{
    public class ClsSqlAdministrator
    {
        static readonly string lSchema = "Administrator";

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

        public static DataTable Fx_sel_tblUser(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblUser", lParameters);

            return ObjDt;
        }

        public static DataTable Fx_sel_tblUser_detail(long pUserId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "UserId" };
            lParameters[1] = new object[] { pUserId };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblUser_detail", lParameters);

            return ObjDt;
        }

        public static long Fx_ins_tblUser(string pName, string pUserName)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Name", "UserName" };
            lParameters[1] = new object[] { pName, pUserName };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_ins_tblUser", lParameters);

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

        public static long Fx_upt_tblUser(long pUserId, string pName, string pUserName, bool pEnabled)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "UserId", "Name", "UserName", "Enabled" };
            lParameters[1] = new object[] { pUserId, pName, pUserName, pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_upt_tblUser", lParameters);

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

        public static long Fx_upt_tblUser_resetPassword(long pUserId)
        {
            long lUserId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "UserId", "Password" };
            lParameters[1] = new object[] { pUserId, "centuria" };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, "Administrator", "sp_upt_tblUser_password", lParameters);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    try
                    {
                        lUserId = long.Parse(ObjDt.Rows[0][0].ToString());
                    }
                    catch
                    {
                        lUserId = 0;
                    }
                }

                ObjDt.Dispose();
            }

            return lUserId;
        }

        public static DataTable Fx_sel_tblModule(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblModule", lParameters);

            return ObjDt;
        }

        public static DataTable Fx_sel_tblModule_detail(long pModuleId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "ModuleId" };
            lParameters[1] = new object[] { pModuleId };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblModule_detail", lParameters);

            return ObjDt;
        }

        public static Bitmap Fx_sel_tblModuleLogo(long pModuleId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "ModuleId" };
            lParameters[1] = new object[] { pModuleId };

            Bitmap ObjImage = FxSqlImage(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblModuleLogo", lParameters);

            return ObjImage;
        }

        public static long Fx_ins_tblModule(string pName, string pDescription, string pExecutable)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Name", "Description", "Executable" };
            lParameters[1] = new object[] { pName, pDescription, pExecutable };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_ins_tblModule", lParameters);

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

            return lId;
        }

        public static long Fx_upt_tblModule(long pModuleId, string pName, string pDescription, string pExecutable, bool pEnabled)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "ModuleId", "Name", "Description", "Executable", "Enabled" };
            lParameters[1] = new object[] { pModuleId, pName, pDescription, pExecutable, pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_upt_tblModule", lParameters);

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

            return lId;
        }

        public static long Fx_ins_tblModuleLogo(long pModuleId, string pFileName)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "ModuleId", "Logo" };
            lParameters[1] = new object[] { pModuleId, pFileName };

            DataTable ObjDt = ClsConnection.FxSqlExecuteImage(ClsVariables.gDatabaseCore, lSchema, "sp_ins_tblModuleLogo", lParameters);

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

            return lId;
        }

        public static DataTable Fx_sel_tblProfile(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblProfile", lParameters);

            return ObjDt;
        }

        public static DataTable Fx_sel_tblProfile_detail(long pProfileId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "ProfileId" };
            lParameters[1] = new object[] { pProfileId};

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblProfile_detail", lParameters);

            return ObjDt;
        }

        public static long Fx_ins_tblProfile(string pName)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Name" };
            lParameters[1] = new object[] { pName};

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_ins_tblProfile", lParameters);

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

        public static long Fx_upt_tblProfile(long pProfileId, string pName, bool pEnabled)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "ProfileId", "Name", "Enabled" };
            lParameters[1] = new object[] { pProfileId, pName, pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_upt_tblProfile", lParameters);

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

        public static DataTable Fx_sel_tblStore(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblStore", lParameters);

            return ObjDt;
        }

        public static DataTable Fx_sel_tblStore_detail(long pStoreId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "StoreId" };
            lParameters[1] = new object[] { pStoreId };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblStore_detail", lParameters);

            return ObjDt;
        }

        public static long Fx_ins_tblStore(string pName)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Name" };
            lParameters[1] = new object[] { pName };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_ins_tblStore", lParameters);

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

        public static long Fx_upt_tblStore(long pStoreId, string pName, bool pEnabled)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "StoreId", "Name", "Enabled" };
            lParameters[1] = new object[] { pStoreId, pName, pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_upt_tblStore", lParameters);

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

        public static DataTable Fx_sel_tblAction(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblAction", lParameters);

            return ObjDt;
        }

        public static DataTable Fx_sel_tblAction_detail(long pActionId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "ActionId" };
            lParameters[1] = new object[] { pActionId };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblAction_detail", lParameters);

            return ObjDt;
        }

        public static long Fx_ins_tblAction(string pName)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Name"};
            lParameters[1] = new object[] { pName };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_ins_tblAction", lParameters);

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

        public static long Fx_upt_tblAction(long pActionId, string pName, bool pEnabled)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "ActionId", "Name", "Enabled" };
            lParameters[1] = new object[] { pActionId, pName, pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_upt_tblAction", lParameters);

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

        public static DataTable Fx_sel_tblOptionType(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblOptionType", lParameters);

            return ObjDt;
        }

        public static DataTable Fx_sel_tblOptionType_detail(long pOptionTypeId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "OptionTypeId" };
            lParameters[1] = new object[] { pOptionTypeId };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblOptionType_detail", lParameters);

            return ObjDt;
        }

        public static long Fx_ins_tblOptionType(string pName)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Name"};
            lParameters[1] = new object[] { pName};

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_ins_tblOptionType", lParameters);

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

        public static long Fx_upt_tblOptionType(long pOptionTypeId, string pName, bool pEnabled)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "OptionTypeId", "Name", "Enabled" };
            lParameters[1] = new object[] { pOptionTypeId, pName, pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_upt_tblOptionType", lParameters);

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

        public static DataTable Fx_sel_tblCompany(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblCompany", lParameters);

            return ObjDt;
        }

        public static DataTable Fx_sel_tblCompany_detail(long pCompanyId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "CompanyId" };
            lParameters[1] = new object[] { pCompanyId };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_sel_tblCompany_detail", lParameters);

            return ObjDt;
        }

        public static long Fx_ins_tblCompany(string pName, string pTradeName, string pShortName, string pDBName )
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Name", "TradeName", "ShortName", "DBName" };
            lParameters[1] = new object[] { pName, pTradeName, pShortName, pDBName };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_ins_tblCompany", lParameters);

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

        public static long Fx_upt_tblCompany(long pCompanyId, string pName, string pTradeName, string pShortName, string pDBName, bool pEnabled)
        {
            long lId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "CompanyId", "Name", "TradeName", "ShortName", "DBName", "Enabled" };
            lParameters[1] = new object[] { pCompanyId, pName, pTradeName, pShortName, pDBName , pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabaseCore, lSchema, "sp_upt_tblCompany", lParameters);

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
