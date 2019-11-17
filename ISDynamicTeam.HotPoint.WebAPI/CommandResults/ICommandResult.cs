using System;

namespace ISDynamicTeam.HotPoint.WebAPI.Commands
{
    public interface ICommandResult : IDisposable {
        byte[] CompressedData { get; set; }
     
    }
}
