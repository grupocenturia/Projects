using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Centuria
{
    class ClsFunctions
    {
        internal static void FxCreateWorkingPath()
        {
            ClsVariables.gPathBin = ClsVariables.gPathRoot + "Bin\\";
            ClsVariables.gPathDocs = ClsVariables.gPathRoot + "Docs\\";
            ClsVariables.gPathTemp = ClsVariables.gPathRoot + "Temp\\";

            Directory.CreateDirectory(ClsVariables.gPathDocs);
            Directory.CreateDirectory(ClsVariables.gPathTemp);

            FxCreateTempPath();
        }

        internal static void FxCreateTempPath()
        {
            string lHash = FxRandomHash();

            if (lHash.Length > 0)
            {
                ClsVariables.gPathTemp += lHash;

                Directory.CreateDirectory(ClsVariables.gPathTemp);
            }
        }

        internal static string FxRandomHash()
        {
            int lNumber = FxRandomNumber();

            string lHash = FxConvertTextToMD5(lNumber.ToString());

            return lHash;
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
            string lHash = "";

            using (MD5 ObjMD5 = MD5.Create())
            {
                byte[] ObjEncode = Encoding.Default.GetBytes(pText);

                byte[] ObjHash = ObjMD5.ComputeHash(ObjEncode);

                lHash = BitConverter.ToString(ObjHash).Replace("-", "").ToLowerInvariant();
            }

            return lHash;
        }

        internal static bool FxGetSettings()
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
                    string lServer = (string)ObjJson.SelectToken("Server");
                    string lPathUpdate = (string)ObjJson.SelectToken("PathUpdate");

                    if (string.IsNullOrEmpty(lServer))
                    {
                        lOk = false;
                    }
                    else
                    {
                        lOk = true;

                        lServer = lServer.Trim();

                        ClsVariables.gServer = lServer;
                    }

                    if (string.IsNullOrEmpty(lPathUpdate))
                    {
                        lOk = false;
                    }
                    else
                    {
                        lOk = true;

                        lPathUpdate = lPathUpdate.Trim();

                        ClsVariables.gPathUpdate = lPathUpdate;
                    }
                }
            }

            if(lOk == true)
            {
                DataTable ObjDt = ClsSql.Fx_sel_tblSetting();

                if (ObjDt == null)
                {
                    lOk = false;
                }
            }

            return lOk;
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

        internal static string[] FxGetFilesFromPath(string pPath)
        {
            string[] lFiles = Directory.GetFiles(pPath);

            return lFiles;
        }

        internal static void FxUpdateFile(string pFileSource, string pPathDestination)
        {
            string lFileName = FxGetFileName(pFileSource);
            string lFileDestination = pPathDestination + "\\" + lFileName;

            string lHashSource = FxConvertFileToMD5(pFileSource);
            string lHashDestination = FxConvertFileToMD5(lFileDestination);

            if(lHashSource != lHashDestination)
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

        internal static string FxGetFileName(string pFile)
        {
            string lFileName = Path.GetFileName(pFile);

            return lFileName;
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

        internal static void FxPause(int pMiliseconds)
        {
            Thread.Sleep(pMiliseconds);
        }

        internal static void FxSelectAll(object pTextBox)
        {
            TextBox ObjText = (TextBox)pTextBox;

            ObjText.SelectAll();
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

        internal static void FxWriteJsonSettings(string pServer, string pPathUpdate)
        {
            bool lOk;

            string lFile = ClsVariables.gPathBin + "Settings.ini";

            dynamic ObjJson = new JObject();

            ObjJson.Server = pServer;
            ObjJson.PathUpdate = pPathUpdate;

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
        
        internal static bool FxCheckPath(string pPath)
        {
            bool lOk;

            try
            {
                lOk = Directory.Exists(pPath);
            }
            catch
            {
                lOk = false;
            }

            return lOk;
        }

        internal static string FxSelectPath()
        {
            string lPath = "";

            OpenFileDialog ObjFileDialog = new OpenFileDialog();

            ObjFileDialog.Title = "Seleccione carpeta";
            ObjFileDialog.FileName = "Seleccione carpeta";
            ObjFileDialog.InitialDirectory = "C:\\";
            ObjFileDialog.ValidateNames = false;
            ObjFileDialog.CheckFileExists = false;
            ObjFileDialog.CheckPathExists = true;

            if (ObjFileDialog.ShowDialog() == DialogResult.OK)
            {
                lPath = Path.GetDirectoryName(ObjFileDialog.FileName) + "\\";
            }

            if (string.IsNullOrEmpty(lPath) == true)
            {
                lPath = "";
            }

            return lPath;
        }
    }
}
