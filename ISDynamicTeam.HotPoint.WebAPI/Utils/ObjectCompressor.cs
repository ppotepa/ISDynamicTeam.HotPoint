using ISDynamicTeam.HotPoint.WebAPI.Commands;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;

namespace ISDynamicTeam.HotPoint.WebAPI.Utils
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
