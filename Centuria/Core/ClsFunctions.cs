using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Core
{
    public class ClsFunctions
    {
        public static void FxMessage(string pMessage)
        {
            FxMessage(0, pMessage);
        }

        public static bool FxMessage(int pType, string pMessage)
        {
            bool lOk = false;

            if (pType == 1)
            {
                lOk = true;

                MessageBox.Show(pMessage, ClsVariables.gTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (pType == 2)
            {
                if (MessageBox.Show(pMessage, ClsVariables.gTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    lOk = true;
                }
            }
            else
            {
                lOk = true;

                MessageBox.Show(pMessage, ClsVariables.gTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return lOk;
        }

        public static void FxGetParametersFromCore(string pParameters)
        {
            string lText = FxDecrypt(pParameters, "GrupoCenturia2020--");

            string[] ObjText = lText.Split('|');

            try
            {
                ClsVariables.gUserId = long.Parse(ObjText[0]);
                ClsVariables.gCompanyId = long.Parse(ObjText[1]);
                ClsVariables.gModuleId = long.Parse(ObjText[2]);
                ClsVariables.gServer = ObjText[3];
                ClsVariables.gPathRoot = ObjText[4];
                ClsVariables.gPathTemp = ObjText[5];

                ClsVariables.gPathDocs = ClsVariables.gPathRoot + "Docs\\";
            }
            catch
            {
                ClsVariables.gUserId = 0;
            }

            if (ClsVariables.gUserId > 0)
            {
                FxGetUserName();
                FxGetCompany();
                FxGetModule();
            }
        }

        internal static string FxDecrypt(string pText, string pPassword)
        {
            byte[] ObjText;

            byte[] ObjHash = FxGetTextMD5Hash(pPassword);

            TripleDESCryptoServiceProvider Obj3DES = new TripleDESCryptoServiceProvider()
            {
                Key = ObjHash,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            byte[] ObjBuffer = Convert.FromBase64String(pText);

            try
            {
                ICryptoTransform ObjDecrypt = Obj3DES.CreateDecryptor();

                ObjText = ObjDecrypt.TransformFinalBlock(ObjBuffer, 0, ObjBuffer.Length);
            }
            finally
            {
                Obj3DES.Clear();
            }

            return Encoding.UTF8.GetString(ObjText);
        }

        internal static byte[] FxGetTextMD5Hash(string pText)
        {
            byte[] ObjHash;

            using (MD5 ObjMD5 = MD5.Create())
            {
                byte[] ObjEncode = Encoding.UTF8.GetBytes(pText);

                ObjHash = ObjMD5.ComputeHash(ObjEncode);
            }

            return ObjHash;
        }

        internal static void FxGetUserName()
        {
            string lUserName = "";

            DataTable ObjDt = ClsSqlAdministrator.Fx_sel_tblUser_detail(ClsVariables.gUserId);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    try
                    {
                        lUserName = ObjDt.Rows[0][1].ToString();
                    }
                    catch
                    {
                        lUserName = "";
                    }
                }
            }

            ClsVariables.gUserName = lUserName;
        }

        internal static void FxGetCompany()
        {
            string lCompany = "";
            string lDBName = "";

            DataTable ObjDt = ClsSqlAdministrator.Fx_sel_tblCompany_detail(ClsVariables.gCompanyId);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    try
                    {
                        lCompany = ObjDt.Rows[0][0].ToString();
                        lDBName = ObjDt.Rows[0][3].ToString();
                    }
                    catch
                    {
                        lCompany = "";
                        lDBName = "";
                    }
                }
            }

            ClsVariables.gCompany = lCompany;
            ClsVariables.gDatabase = lDBName;
        }

        internal static void FxGetModule()
        {
            string lModule = "";

            DataTable ObjDt = ClsSqlAdministrator.Fx_sel_tblModule_detail(ClsVariables.gModuleId);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    try
                    {
                        lModule = ObjDt.Rows[0][0].ToString();
                    }
                    catch
                    {
                        lModule = "";
                    }
                }
            }

            ClsVariables.gModule = lModule;
        }

        public static string FxStatusBar()
        {
            string lStatusBar = ClsVariables.gTitle + " | " + ClsVariables.gUserName + " | " + ClsVariables.gCompany + " | " + ClsVariables.gModule;

            return lStatusBar;
        }

        internal static void FxExit()
        {
            FxDeleteFiles(ClsVariables.gPathTemp);

            Application.Exit();
        }

        internal static void FxDeleteFiles(string pPath)
        {
            DirectoryInfo ObjDirectory = new DirectoryInfo(pPath);

            if (Directory.Exists(pPath) == true)
            {
                foreach (FileInfo ObjFile in ObjDirectory.GetFiles())
                {
                    try
                    {
                        ObjFile.Delete();
                    }
                    catch
                    {
                        continue;
                    }
                }

                foreach (DirectoryInfo ObjSubDirectory in ObjDirectory.GetDirectories())
                {
                    FxDeleteFiles(ObjSubDirectory.FullName);

                    try
                    {
                        ObjSubDirectory.Delete();
                    }
                    catch
                    {
                        continue;
                    }
                }

                try
                {
                    ObjDirectory.Delete();
                }
                catch
                {
                    return;
                }
            }
        }

        public static void FxSelectAll(object pTextBox)
        {
            TextBox ObjText = (TextBox)pTextBox;

            ObjText.SelectAll();
        }

        public static bool FxConvertStringToBool(string pValue)
        {
            bool lReturn;

            try
            {
                lReturn = bool.Parse(pValue);
            }
            catch
            {
                lReturn = false;
            }

            return lReturn;
        }

        public static int FxRandomNumber()
        {
            RNGCryptoServiceProvider ObjRandom = new RNGCryptoServiceProvider();

            byte[] ObjBuffer = new byte[4];

            ObjRandom.GetBytes(ObjBuffer);

            int lRandom = Math.Abs(BitConverter.ToInt32(ObjBuffer, 0));

            return lRandom;
        }

        public static bool FxDeleteFile(string pFile)
        {
            bool lOk = true;

            if (File.Exists(pFile))
            {
                try
                {
                    File.Delete(pFile);
                }
                catch
                {
                    lOk = false;

                    FxMessage(1, "El archivo no puede ser eliminado");
                }
            }

            return lOk;
        }

        internal static byte[] FxConvertFileByte(string pFileName)
        {
            byte[] ObjBuffer = null;

            if (pFileName.Length > 0)
            {
                FileStream ObjStream = new FileStream(pFileName, FileMode.Open, FileAccess.Read);

                BinaryReader ObjReader = new BinaryReader(ObjStream);

                long lTotalBytes = new FileInfo(pFileName).Length;

                ObjBuffer = ObjReader.ReadBytes((int)lTotalBytes);

                ObjReader.Close();
                ObjReader.Dispose();

                ObjStream.Close();
                ObjStream.Dispose();
            }

            return ObjBuffer;
        }

        public static void FxDebugParameters()
        {
            ClsVariables.gUserId = 1;
            ClsVariables.gCompanyId = 1;
            ClsVariables.gModuleId = 1;
            ClsVariables.gServer = "localhost";
            ClsVariables.gPathRoot = "C:\\Centuria\\";
            ClsVariables.gPathDocs = ClsVariables.gPathRoot + "Docs\\";
            ClsVariables.gPathTemp = ClsVariables.gPathRoot + "Temp\\Debug\\";

            Directory.CreateDirectory(ClsVariables.gPathTemp);

            FxGetUserName();
            FxGetCompany();
            FxGetModule();
        }
    }
}
