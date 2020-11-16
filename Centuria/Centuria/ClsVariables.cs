using System;

namespace Centuria
{
    class ClsVariables
    {
        internal static string gTitle = "Centuria";

        internal static string gPathRoot = "C:\\Centuria\\";
        internal static string gPathBin = ClsVariables.gPathRoot + "Bin\\";
        internal static string gPathTemp = ClsVariables.gPathRoot + "Temp\\";

        internal static string gServer;
        internal static string gDatabase = "CNTDB00";

        internal static string gPathUpdate;
        internal static bool gAuthentication;
        internal static long gPasswordExpiry;
        internal static long gPasswordAlert;

        internal static long gUserId;
        internal static string gUserName;
        internal static DateTime gUserExpirationDate;
        internal static bool gPasswordChanged;
    }
}
