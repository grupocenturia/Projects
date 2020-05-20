namespace WinFormsTest1
{
    class ClsVariables
    {
        internal static string gTitle = "WinFormsTest1";
        internal static string gServer = ClsFunctions.FxServer();

        internal static class ClsPath
        {
            internal static string gDrive = "C";
            internal static string gRoot = gDrive + ":\\GrupoCenturia\\";
            internal static string gBin = gRoot + "Bin\\";
            internal static string gDocs = gRoot + "Docs\\";
            internal static string gTemplates = gRoot + "Templates\\";
            internal static string gRootTemp = gRoot + "Temp\\";
            internal static string gTemp = ClsFunctions.FxCreateTempDirectory();
        }

        internal static class ClsUser
        {
            internal static long gUserId = 0;
            internal static string gUserName = "";
            internal static string gName = "";
        }

        internal static class ClsCompany
        {
            internal static long gCompanyId = 0;
            internal static string gName = "";
        }
    }
}
