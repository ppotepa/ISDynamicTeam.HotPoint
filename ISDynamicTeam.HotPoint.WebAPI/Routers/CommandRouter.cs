using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISDynamicTeam.HotPoint.WebAPI.Routers
{
    public class CommandRouter
    {
        private static IDictionary<Type, Type> RoutingDictionary = new Dictionary<Type, Type>();
        public CommandRouter()
        {
            if (instantiated == true) throw new InvalidProgramException("CommandRouter already instantiated.");
            else instantiated = true;
        }

        private static CommandRouter _instance = new CommandRouter();
        public CommandRouter Register(Type commandType, Type handlerType)
        {
            RoutingDictionary.Add(commandType, handlerType);
            return this;
        }

        public static Type GetHandler(string commandName)
        {
            return RoutingDictionary.Where(key => key.Key.Name.StartsWith(commandName)).FirstOrDefault().Value;
        }

        public static Type GetCommandType(string commandName)
        {
            return RoutingDictionary.Where(key => key.Key.Name.StartsWith(commandName)).FirstOrDefault().Key; 
        }

        private static bool instantiated = false;

    }
}
