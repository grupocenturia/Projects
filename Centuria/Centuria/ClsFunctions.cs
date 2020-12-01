using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Centuria
{
    class ClsFunctions
    {
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

        internal static void FxPause(double pSeconds)
        {
            Thread.Sleep((int)(pSeconds * 1000));
        }

        internal static void FxCreateWorkingPaths()
        {
            Directory.CreateDirectory(ClsVariables.gPathRoot);
            Directory.CreateDirectory(ClsVariables.gPathBin);
            Directory.CreateDirectory(ClsVariables.gPathTemp);

            FxCreateTempPath();
        }

        internal static void FxCreateTempPath()
        {
            int lNumber = FxRandomNumber();

            string lHash = FxConvertTextToMD5(lNumber.ToString());

            if (lHash.Length > 0)
            {
                ClsVariables.gPathTemp = ClsVariables.gPathRoot + "Temp\\" + lHash + "\\";

                Directory.CreateDirectory(ClsVariables.gPathTemp);
            }
        }

        internal static int FxRandomNumber()
        {
            RNGCryptoServiceProvider ObjRandom = new RNGCryptoServiceProvider();

            byte[] ObjBuffer = new byte[4];

            ObjRandom.GetBytes(ObjBuffer);

            int lRandom = Math.Abs(BitConverter.ToInt32(ObjBuffer, 0));

            return lRandom;
        }

        internal static string FxConvertTextToMD5(string pText)
        {
            string lHash;

            try
            {
                byte[] ObjHash = FxGetTextMD5Hash(pText);

                lHash = BitConverter.ToString(ObjHash).Replace("-", "").ToLowerInvariant();
            }
            catch
            {
                lHash = "";
            }

            return lHash;
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

        internal static bool FxGetSettingIni()
        {
            bool lOk;

            string lFile = ClsVariables.gPathBin + "Settings.ini";

            try
            {
                lOk = File.Exists(lFile);
            }
            catch
            {
                lOk = false;
            }

            if (lOk == true)
            {
                JObject ObjJson = FxGetJsonFromFile(lFile);

                if (ObjJson != null)
                {
                    string lServer;

                    try
                    {
                        lServer = (string)ObjJson.SelectToken("Server");

                        lServer = lServer.Trim();
                    }
                    catch
                    {
                        lServer = "";
                    }

                    if (lServer == "")
                    {
                        lOk = false;
                    }
                    else
                    {
                        lOk = true;

                        ClsVariables.gServer = lServer;
                    }
                }
            }

            return lOk;
        }

        internal static JObject FxGetJsonFromFile(string pFile)
        {
            JObject ObjJson;

            try
            {
                ObjJson = JObject.Parse(File.ReadAllText(pFile));
            }
            catch
            {
                ObjJson = null;
            }

            return ObjJson;
        }

        internal static void FxSelectAll(object pTextBox)
        {
            TextBox ObjText = (TextBox)pTextBox;

            ObjText.SelectAll();
        }

        internal static void FxMessage(string pMessage)
        {
            FxMessage(0, pMessage);
        }

        internal static bool FxMessage(int pType, string pMessage)
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

        internal static void FxWriteJsonSettings(string pServer)
        {
            bool lOk;

            string lFile = ClsVariables.gPathBin + "Settings.ini";

            dynamic ObjJson = new JObject();

            ObjJson.Server = pServer;

            for (int lCounter = 0; lCounter < 3; lCounter++)
            {
                lOk = FxWriteJson(lFile, ObjJson);

                if (lOk == true)
                {
                    break;
                }

                lCounter += 1;

                if (lCounter == 3)
                {
                    FxMessage(1, "Configuración no fue guardada");
                }
            }
        }

        internal static bool FxWriteJson(string pFile, JObject pJson)
        {
            bool lOk;

            try
            {
                lOk = true;

                File.WriteAllText(pFile, pJson.ToString());
            }
            catch
            {
                lOk = false;
            }

            return lOk;
        }

        internal static bool FxGetSettings()
        {
            bool lOk = false;

            DataTable ObjDt = ClsSql.Fx_sel_tblSetting(true);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    lOk = true;

                    foreach (DataRow ObjRow in ObjDt.Rows)
                    {
                        string lVariable = ObjRow[2].ToString();
                        string lValue = ObjRow[3].ToString();

                        if (lVariable == "PathUpdate")
                        {
                            ClsVariables.gPathUpdate = lValue;
                        }

                        if (lVariable == "Authentication")
                        {
                            ClsVariables.gAuthentication = FxConvertTextToBool(lValue);
                        }

                        if (lVariable == "PasswordExpiry")
                        {
                            ClsVariables.gPasswordExpiry = FxConvertTextToLong(lValue);
                        }

                        if (lVariable == "PasswordAlert")
                        {
                            ClsVariables.gPasswordAlert = FxConvertTextToLong(lValue);
                        }
                    }
                }
            }

            return lOk;
        }

        internal static bool FxConvertTextToBool(string pText)
        {
            bool lReturn = false;

            if (pText == "1")
            {
                lReturn = true;
            }

            return lReturn;
        }

        internal static long FxConvertTextToLong(string pText)
        {
            long lReturn;

            try
            {
                lReturn = long.Parse(pText);
            }
            catch
            {
                lReturn = 0;
            }

            return lReturn;
        }

        internal static string[] FxGetFilesFromPath(string pPath)
        {
            string[] lFiles = Directory.GetFiles(pPath);

            return lFiles;
        }

        internal static string FxGetFileName(string pFile)
        {
            string lFileName = Path.GetFileName(pFile);

            return lFileName;
        }

        internal static void FxUpdateFile(string pFileSource, string pPathDestination)
        {
            string lFileName = FxGetFileName(pFileSource);
            string lFileDestination = pPathDestination + "\\" + lFileName;

            string lHashSource = FxConvertFileToMD5(pFileSource);
            string lHashDestination = FxConvertFileToMD5(lFileDestination);

            if (lHashSource != lHashDestination)
            {
                try
                {
                    File.Copy(pFileSource, lFileDestination, true);
                }
                catch
                {

                }
            }
        }

        internal static string FxConvertFileToMD5(string pFile)
        {
            string lHash = "";

            using (MD5 ObjMD5 = MD5.Create())
            {
                FileStream ObjFileStream;

                try
                {
                    ObjFileStream = File.OpenRead(pFile);
                }
                catch
                {
                    ObjFileStream = null;
                }

                if (ObjFileStream != null)
                {
                    byte[] ObjHash = ObjMD5.ComputeHash(ObjFileStream);

                    lHash = BitConverter.ToString(ObjHash).Replace("-", "").ToLowerInvariant();

                    ObjFileStream.Close();
                }

                ObjFileStream = null;
            }

            return lHash;
        }

        internal static string FxGetWindowsUserName()
        {
            string lUserName = Environment.UserName;

            return lUserName;
        }

        internal static string FxModuleParameters(long pCompanyId, long pModuleId)
        {
            string lParameters = (ClsVariables.gUserId.ToString() + "|" + pCompanyId.ToString() + "|" + pModuleId.ToString() + "|" + ClsVariables.gServer + "|" + ClsVariables.gPathRoot + "|" + ClsVariables.gPathTemp);

            string lCryptedParameters = FxEncrypt(lParameters, "GrupoCenturia2020--");

            return lCryptedParameters;
        }

        internal static string FxEncrypt(string pText, string pPassword)
        {
            byte[] ObjText;

            byte[] ObjHash = FxGetTextMD5Hash(pPassword);

            TripleDESCryptoServiceProvider Obj3DES = new TripleDESCryptoServiceProvider
            {
                Key = ObjHash,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            byte[] ObjEncode = Encoding.UTF8.GetBytes(pText);

            try
            {
                ICryptoTransform ObjCrypt = Obj3DES.CreateEncryptor();

                ObjText = ObjCrypt.TransformFinalBlock(ObjEncode, 0, ObjEncode.Length);
            }
            finally
            {
                Obj3DES.Clear();
            }

            return Convert.ToBase64String(ObjText);
        }

        internal static void FxRunModule(string pExecutable, string pParameters)
        {
            Process ObjProcess = new Process();

            try
            {
                ObjProcess.StartInfo.FileName = pExecutable;
                ObjProcess.StartInfo.Arguments = pParameters;

                ObjProcess.StartInfo.UseShellExecute = false;
                ObjProcess.StartInfo.CreateNoWindow = true;

                ObjProcess.Start();
                ObjProcess.WaitForExit();
            }
            catch
            {
                FxMessage(1, "El módulo no está implementado");
            }

            ObjProcess.Close();
        }

        internal static string FxStatusBar()
        {
            string lStatusBar = ClsVariables.gTitle + " | " + ClsVariables.gUserName;

            return lStatusBar;
        }

        internal static bool FxValidPassword(string pPassword)
        {
            bool lValidPassword = false;
            bool lHasWhiteSpace = false;
            bool lHasUpper = false;
            bool lHasLower = false;
            bool lHasDigit = false;

            if (pPassword.Length >= 8)
            {
                foreach(char lChar in pPassword)
                {
                    if (char.IsWhiteSpace(lChar))
                    {
                        lHasWhiteSpace = true;
                    }
                    else if (char.IsUpper(lChar))
                    {
                        lHasUpper = true;
                    }
                    else if (char.IsLower(lChar))
                    {
                        lHasLower = true;
                    }
                    else if (char.IsDigit(lChar))
                    {
                        lHasDigit = true;
                    }
                }

                if (lHasWhiteSpace == false && lHasUpper == true && lHasLower == true && lHasDigit == true)
                {
                    lValidPassword = true;
                }
            }

            if (lValidPassword == false)
            {
                FxMessage(1, "La contaseña es débil. Debe contener como mínimo 8 dígitos, al menos una mayúscula, al menos una minúscula, al menos un número y no debe contener espacios");
            }

            return lValidPassword;
        }

        internal static void FxExpirationAlert()
        {
            long lExpirationLeft = (ClsVariables.gUserExpirationDate - DateTime.Today).Days;

            if (lExpirationLeft <= ClsVariables.gPasswordAlert)
            {
                if (lExpirationLeft == 1)
                {
                    ClsFunctions.FxMessage("Falta " + lExpirationLeft.ToString() + " día para que su contraseña expire. Favor cambiar su contraseña pronto");
                }
                else
                {
                    ClsFunctions.FxMessage("Faltan " + lExpirationLeft.ToString() + " días para que su contraseña expire. Favor cambiar su contraseña pronto");
                }
            }
        }

        internal static Bitmap FxGetModuleLogo(long pModuleId)
        {
            Bitmap ObjLogo;

            try
            {
                ObjLogo = ClsSql.Fx_sel_tblModuleLogo(pModuleId);
            }
            catch
            {
                ObjLogo = null;
            }

            return ObjLogo;
        }
    }
}
