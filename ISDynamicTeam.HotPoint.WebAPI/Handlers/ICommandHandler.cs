using ISDynamicTeam.HotPoint.WebAPI.Commands;

namespace ISDynamicTeam.HotPoint.WebAPI.Handlers
{
    public interface ICommandHandler
    {
        ICommandResult Handle();
    }
}
