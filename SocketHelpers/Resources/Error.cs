using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketHelpers
{
    class ClErrors
    {
        public static Boolean blFileError = true;
        public static Boolean blConsoleError = true;
        public static Boolean blMsgError = false;
        public static Boolean blBddError = false;
        public static Boolean btMailError = false;

        private static String fileError = "";

        public static String FileError
        {
            get { return fileError; }
            set
            {
                if (value != "")
                    fileError = value;
            }
        }

        public static void reportError(String errorMsg)
        {
            errorMsg = DateTime.Now + ": " + errorMsg;
            if (blFileError)
            {
                if (fileError == "")
                {
                    fileError = Application.StartupPath + "/errorLogs.txt";
                }
                File.WriteAllText(fileError, errorMsg, Encoding.UTF8);
            }
            if (blConsoleError)
            {
                Console.WriteLine(errorMsg);
            }
            if (blMsgError)
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (blBddError)
            {
                
            }
            if (btMailError)
            {
                
            }
        }
    }
}
