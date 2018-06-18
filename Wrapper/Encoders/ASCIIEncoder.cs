using System.Linq;

namespace Wrapper.Encoders
{
    public class ASCIIEncoder : Encoder
    {
        public override byte[] DecodeData(string encoded)
        {
            return string.IsNullOrEmpty(encoded) ? new byte[0] : encoded.ToCharArray().Select(o => (byte)o).ToArray();
        }

        public override string EncodeData(byte[] data, int offset, int count)
        {
            return new string(data.Skip(offset).Take(count).Select(o => (char)o).ToArray()).Replace("\0", "");
        }
    }
}
