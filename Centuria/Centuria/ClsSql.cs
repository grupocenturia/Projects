using System.Data;

namespace Centuria
{
    class ClsSql
    {
        internal static DataTable Fx_sel_tblSetting()
        {
            DataTable ObjDt = ClsConnection.FxSqlExecute("Administrator", "sp_sel_tblSetting");

            return ObjDt;
        }
    }
}
