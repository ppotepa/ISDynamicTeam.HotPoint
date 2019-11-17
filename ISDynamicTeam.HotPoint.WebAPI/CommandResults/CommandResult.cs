using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace ISDynamicTeam.HotPoint.WebAPI.Commands
{
    [Serializable]
    public class CommandResult : ICommandResult
    {
        bool disposed = false;
        private byte[] compressedData;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            disposed = true;
        }

        public byte[] ToByteArray()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                binaryFormatter.Serialize(memoryStream, this);
                byte[] byteArray = memoryStream.ToArray();
                return byteArray;
            }
        }
        private CommandResult(byte[] compressedData) { this.CompressedData = compressedData; }
        public CommandResult() { }


        public byte[] CompressedData { get => compressedData; set => compressedData = value; }
    }
}
