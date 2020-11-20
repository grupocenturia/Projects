using System;
using System.Data;
using System.Drawing;
using System.IO;

namespace Centuria
{
    class ClsSql
    {
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

        internal static DataTable Fx_sel_tblSetting(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabase, "Administrator", "sp_sel_tblSetting", lParameters);

            return ObjDt;
        }

        internal static long Fx_sel_tblUser_check(string pUserName)
        {
            long lUserId = 0;
            string lUserName;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "UserName" };
            lParameters[1] = new object[] { pUserName };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabase, "Administrator", "sp_sel_tblUser_check", lParameters);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    try
                    {
                        lUserId = long.Parse(ObjDt.Rows[0][0].ToString());
                        lUserName = ObjDt.Rows[0][2].ToString();
                    }
                    catch
                    {
                        lUserId = 0;
                        lUserName = "";
                    }

                    if (lUserId > 0)
                    {
                        ClsVariables.gUserId = lUserId;
                        ClsVariables.gUserName = lUserName;
                    }
                }

                ObjDt.Dispose();
            }

            return lUserId;
        }

        internal static long Fx_sel_tblUser_checkPassword(string pUserName, string pPassword)
        {
            long lUserId = 0;
            string lUserName;
            DateTime lExpirationDate;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "UserName", "Password" };
            lParameters[1] = new object[] { pUserName, pPassword };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabase, "Administrator", "sp_sel_tblUser_checkPassword", lParameters);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    try
                    {
                        lUserId = long.Parse(ObjDt.Rows[0][0].ToString());
                        lUserName = ObjDt.Rows[0][2].ToString();
                        lExpirationDate = DateTime.Parse(ObjDt.Rows[0][3].ToString());
                    }
                    catch
                    {
                        lUserId = 0;
                        lUserName = "";
                        lExpirationDate = DateTime.Today;
                    }

                    if (lUserId > 0)
                    {
                        ClsVariables.gUserId = lUserId;
                        ClsVariables.gUserName = lUserName;
                        ClsVariables.gUserExpirationDate = lExpirationDate;
                    }
                }

                ObjDt.Dispose();
            }

            return lUserId;
        }

        internal static long Fx_upt_tblUser_password(long pUserId, string pPassword)
        {
            long lUserId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "UserId", "Password" };
            lParameters[1] = new object[] { pUserId, pPassword };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabase, "Administrator", "sp_upt_tblUser_password", lParameters);

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

        internal static DataTable Fx_sel_tblUser_company(long pUserId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "UserId" };
            lParameters[1] = new object[] { pUserId };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabase, "Administrator", "sp_sel_tblUser_company", lParameters);

            return ObjDt;
        }

        internal static DataTable Fx_sel_tblUser_companyModule(long pUserId, long pCompanyId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "UserId", "CompanyId" };
            lParameters[1] = new object[] { pUserId, pCompanyId };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabase, "Administrator", "sp_sel_tblUser_companyModule", lParameters);

            return ObjDt;
        }

        internal static DataTable Fx_sel_tblCompany(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabase, "Administrator", "sp_sel_tblCompany", lParameters);

            return ObjDt;
        }

        internal static DataTable Fx_sel_tblModule(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute(ClsVariables.gDatabase, "Administrator", "sp_sel_tblModule", lParameters);

            return ObjDt;
        }

        internal static Bitmap Fx_sel_tblModuleLogo(long pModuleId)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "ModuleId" };
            lParameters[1] = new object[] { pModuleId };

            Bitmap ObjImage = FxSqlImage(ClsVariables.gDatabase, "Administrator", "sp_sel_tblModuleLogo", lParameters);

            return ObjImage;
        }

  
    }
}
