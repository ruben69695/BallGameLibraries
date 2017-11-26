using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketHelpers
{
    public class ClPort
    {
        private static int initialPort = 5000;

        /// <summary>
        /// Function to generate port from the ip.
        /// </summary>
        /// <param name="ipOrigin">ip</param>
        /// <returns>If there is no error returns true.</returns>
        public static int GeneratePorts(String ipOrigin)
        {
            int port = 0;
            if (ipOrigin != "")
            {
                port = initialPort + ipOrigin.Trim('.')[3];
            }
            else
            {
                ClErrors.reportError("Incorrect IP value.");
            }
            return port;
        }
    }
}
