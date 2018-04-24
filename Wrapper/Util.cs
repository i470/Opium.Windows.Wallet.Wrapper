using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrapper
{
    public static class Util
    {
        public static string DecodeHexMemo(string memoHex)
        {
            if (memoHex.StartsWith("f600000000"))
            {
                return null;
            }

            // should be read with UTF-8
            var bytes = new byte[(memoHex.Length / 2) + 1];
            var count = 0;


            for (var j = 0; j < memoHex.Length; j += 2)
            {
                var str = memoHex.Substring(j, j + 2);
                bytes[count++] = (byte) int.Parse(str);
            }

            // Remove zero padding
            // TODO: may cause problems if UNICODE chars have trailing ZEROS
            while (count > 0)
            {
                if (bytes[count - 1] == 0)
                {
                    count--;
                }
                else
                {
                    break;
                }

            }

            return bytes.ToString();
        }

        public static void RenameFileForMultiVersionBackup(string dir, string file)
        {
            var versionCount = 9;
        }

        public static bool IsZAddress(string address)
        {
            return address != null && address.StartsWith("zk") && address.Length > 40;
        }

        public static Tuple<bool, Exception> DeleteAllFiles(string path)
        {
            var isDeleteSuccess = true;
            Exception ex = null;

            try
            {
                var di = new DirectoryInfo(path);

                foreach (var file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (var dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }

             
            }
            catch (Exception e)
            {
                ex = e;
                isDeleteSuccess = false;
            }

            return new Tuple<bool, Exception>(isDeleteSuccess,ex);
        }

        public static Tuple<string,Exception> GetSettingsDirectory()
        {
            var path = string.Empty;
            Exception ex = null;
            try
            {
                path = Path.Combine(Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData), Resources.BTCPrivateDesktopWalletDir);
            }
            catch (Exception e)
            {
                ex = e;
            }

            return new Tuple<string, Exception>(path,ex);
        }

    }
}