using ISDynamicTeam.HotPoint.WebAPI.Commands;
using System;
using System.Collections.Generic;

namespace ISDynamicTeam.HotPoint.WebAPI.Const
{
    public class CommandActivator
    {
        private static IDictionary<string, Type> CommandTypesDictionary = new Dictionary<string, Type>()
        {
            {"GetRandomNumber", typeof(GetRandomNumberCommand) },
            {"GetRandomNumberOfGuids", typeof(GetRandomNumberOfGuidsCommand) },
            {"GetNearbyPlaces", typeof(GetNearbyPlacesCommand) },
        };

        public static Type GetTypeByName(string CommandName) {
            return CommandTypesDictionary[CommandName];
        }

        public static Command FromCommandName(string commandName)
        {
            Type targetType = GetTypeByName(commandName);
            object instance = Activator.CreateInstance(targetType);
            return (Command) Convert.ChangeType(instance, targetType);
        }

    }
}
