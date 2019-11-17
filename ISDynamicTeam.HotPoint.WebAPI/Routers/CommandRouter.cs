using ISDynamicTeam.HotPoint.Server.Commands;
using ISDynamicTeam.HotPoint.Server.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISDynamicTeam.HotPoint.WebAPI.Routers
{
    public sealed class CommandRouter
    {
        private static  CommandRouter instance = null;
        private static IDictionary<Type, Type> routingDictionary = new Dictionary<Type, Type>();
        public CommandRouter()
        {
            if (instance == null) instance = this;
            else throw new InvalidProgramException("CommandRouter already instantiated.");
        }
        
        public CommandRouter Register<T, U>(Type commandType, Type handlerType) where T:ICommand where U:ICommandHandler
        {
            routingDictionary.Add(commandType, handlerType);
            return this;
        }

        public Type GetHandler<T>(string commandName) where T : ICommandHandler
        {
            return routingDictionary
                .Where(key => key.Key.Name.StartsWith(commandName))
                .FirstOrDefault()
                .Value;
        }

        public Type GetCommandType(string commandName)
        {
            return routingDictionary
                .Where(key => key.Key.Name.StartsWith(commandName))
                .FirstOrDefault()
                .Key; 
        }

        

    }
}
