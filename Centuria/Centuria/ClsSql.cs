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
    }
}
