using ISDynamicTeam.HotPoint.Server.Commands;
using System;
using System.Collections.Generic;

namespace ISDynamicTeam.HotPoint.Server
{
    public class CommandInstanceHelper
    {
        private static IDictionary<string, Type> CommandTypesDictionary = new Dictionary<string, Type>()
        {
           
            {"GetRandomNumberOfGuids", typeof(GetRandomNumberOfGuidsCommand) },
            {"GetRestaurantsByName", typeof(GetRestaurantsByNameCommand) },
          
        };

        //private static IDictionary<string, Type> CommandParametersDictionary = new Dictionary<string, Type>()
        //{
        //    {"GetRandomNumberOfGuids", typeof(GetRandomNumberOfGuidsCommandParameters) },
        //    {"GetRestaurantsByName", typeof(GetRestaurantsByNameCommandParameters) },
        //};

        public static Type GetTypeByName(string CommandName) {
            return CommandTypesDictionary[CommandName];
        }

        //public static Type GetParametersTypeByName(string CommandName)
        //{
        //    return CommandParametersDictionary[CommandName];
        //}

        public static ICommand FromCommandName(string commandName)
        {
            Type targetType = GetTypeByName(commandName);
            object instance = Activator.CreateInstance(targetType);
            return (ICommand) Convert.ChangeType(instance, targetType);
        }

        public static ICommand ConvertFromCommandName(string commandName, ICommand instance)
        {
            Type targetType = GetTypeByName(commandName);
            //IEnumerable<string> constructorProperties = targetType.GetProperties().Select(property=> new { property.Name,  });
            return instance;
        }

        //internal static CommandParameters ParametersFromCommandName(string commandName)
        //{
        //    Type targetType = GetParametersTypeByName(commandName);
        //    object instance = Activator.CreateInstance(targetType);
        //    return (CommandParameters)Convert.ChangeType(instance, targetType);
        //}
       
    }
}
