using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Administrator
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

        internal static void FxPause(double pSeconds)
        {
            Thread.Sleep((int)(pSeconds * 1000));
        }

        internal static void FxSelectAll(object pTextBox)
        {
            TextBox ObjText = (TextBox)pTextBox;

            ObjText.SelectAll();
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

        internal static bool FxConvertTextToBool(string pText)
        {
            bool lReturn = false;

            if (pText == "1")
            {
                lReturn = true;
            }

            return lReturn;
        }

        internal static string FxGetWindowsUserName()
        {
            string lUserName = Environment.UserName;

            return lUserName;
        }

    }
}
