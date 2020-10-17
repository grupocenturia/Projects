using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
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

            string lHash = FxConvertMD5(lNumber.ToString());

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

        internal static string FxConvertMD5(string pText)
        {
            MD5 ObjMD5 = new MD5CryptoServiceProvider();

            byte[] ObjEncode = Encoding.Default.GetBytes(pText);

            byte[] ObjHash = ObjMD5.ComputeHash(ObjEncode);

            string lText = "";

            foreach(byte lByte in ObjHash)
            {
                lText += string.Format("{0:x2}", lByte);
            }

            return lText;
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

            foreach(FileInfo ObjFile in ObjDirectory.GetFiles())
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
