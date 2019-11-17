using System.IO;
using System.IO.Compression;

namespace ISDynamicTeam.HotPoint.Utils
{
    public static class ObjectCompressor
    {
        public  static object Compress(byte[] inputData)
        {
            using (MemoryStream output = new MemoryStream())
            using (DeflateStream dstream = new DeflateStream(output, CompressionLevel.Optimal))
            {
                dstream.Write(inputData, 0, inputData.Length);
                return output.ToArray();
            }
        }
    }
}
