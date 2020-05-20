using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WinFormsTest1
{
    class ClsFunctions
    {
        internal static string FxServer()
        {
            string lServer;

            try
            {
                using (StreamReader ObjSR = new StreamReader(ClsVariables.ClsPath.gBin + "Settings.ini"))
                {
                    lServer = ObjSR.ReadLine();
                }
            }
            catch
            {
                lServer = "localhost";
            }

            return lServer;
        }

        internal static string FxCreateTempDirectory()
        {
            string lPathTemp = ClsVariables.ClsPath.gRootTemp;

            string lHash = FxRandomHash();

            if (lHash.Length > 0)
            {
                lPathTemp = lPathTemp + lHash;

                if (!Directory.Exists(lPathTemp))
                {
                    Directory.CreateDirectory(lPathTemp);
                }

                lPathTemp = lPathTemp + "\\";
            }

            return lPathTemp;
        }

        private static string FxRandomHash()
        {
            int lNumber = FxRandomNumber();

            string lHash = FxConvertMD5(lNumber.ToString());

            return lHash;
        }

        private static int FxRandomNumber()
        {
            RNGCryptoServiceProvider ObjRNG = new RNGCryptoServiceProvider();

            byte[] ObjBuffer = new byte[4];

            ObjRNG.GetBytes(ObjBuffer);

            int lRandom = Math.Abs(BitConverter.ToInt32(ObjBuffer, 0));

            return lRandom;
        }

        private static string FxConvertMD5(string pText)
        {
            MD5 ObjMD5 = new MD5CryptoServiceProvider();

            byte[] ObjData = Encoding.Default.GetBytes(pText);

            byte[] ObjHash = ObjMD5.ComputeHash(ObjData);

            string lText = "";

            foreach (byte lByte in ObjHash)
            {
                lText += string.Format("{0:x2}", lByte);
            }

            return lText;
        }

        internal static bool FxMessage(int pType, string pMessage)
        {
            bool lOk = false;

            switch (pType)
            {
                case 1:
                    lOk = true;

                    MessageBox.Show(pMessage, ClsVariables.gTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    break;

                case 2:
                    if (MessageBox.Show(pMessage, ClsVariables.gTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        lOk = true;
                    }

                    break;

                default:
                    lOk = true;

                    MessageBox.Show(pMessage, ClsVariables.gTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
            }

            return lOk;
        }

        internal static void FxExit()
        {
            FxDeleteFiles(ClsVariables.ClsPath.gTemp);

            Application.Exit();
        }

        private static void FxDeleteFiles(string pPath)
        {
            DirectoryInfo ObjDirectory = new DirectoryInfo(pPath);

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
}
