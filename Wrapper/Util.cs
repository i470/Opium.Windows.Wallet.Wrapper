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

        public static void renameFileForMultiVersionBackup(string dir, string file)
        {
            var versionCount = 9;

            // Delete last one if it exists
            File last = new File(dir, file + "." + versionCount);

            if (last.exists())
            {
                last.delete();
            }

            // Iterate and rename
            for (int i = versionCount - 1; i >= 1; i--)
            {
                File f = new File(dir, file + "." + i);
                int newIndex = i + 1;
                if (f.exists())
                {
                    f.renameTo(new File(dir, file + "." + newIndex));
                }
            }

            // Rename last one
            File orig = new File(dir, file);
            if (orig.exists())
            {
                orig.renameTo(new File(dir, file + ".1"));
            }
        }

    }
}
