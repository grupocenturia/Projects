using System.Data;

namespace Centuria
{
    class ClsSql
    {
        internal static DataTable Fx_sel_tblSetting(bool pEnabled)
        {
            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Enabled" };
            lParameters[1] = new object[] { pEnabled };

            DataTable ObjDt = ClsConnection.FxSqlExecute("Administrator", "sp_sel_tblSetting", lParameters);

            return ObjDt;
        }

        internal static long Fx_sel_tblUser_check(string pUserName)
        {
            long lUserId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "UserName" };
            lParameters[1] = new object[] { pUserName };

            DataTable ObjDt = ClsConnection.FxSqlExecute("Administrator", "sp_sel_tblUser_check", lParameters);

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

            return lUserId;
        }

        internal static long Fx_sel_tblUser_checkPassword(string pUserName, string pPassword)
        {
            long lUserId = 0;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "UserName", "Password" };
            lParameters[1] = new object[] { pUserName, pPassword };

            DataTable ObjDt = ClsConnection.FxSqlExecute("Administrator", "sp_sel_tblUser_checkPassword", lParameters);

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

            return lUserId;
        }
    }
}
