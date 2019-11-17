using ISDynamicTeam.HotPoint.WebAPI.Commands;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ISDynamicTeam.HotPoint.WebAPI.Extensions
{
    public static class ObjectExtensions
    {
        public static byte[] ToByteArray(this object thisObject)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                binaryFormatter.Serialize(memoryStream, thisObject);
                return memoryStream.ToArray();
            }
        }
    }
}
