using System;
using CommandSystem;
using RemoteAdmin;

namespace Testplugin.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class Testcommand : ICommand
    {
        public string Command { get; } = "TestCommand";

        public string[] Aliases { get; } = { "test1" };

        public string Description { get; } = "Test command to see if I can get this to work";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender player)
            {
                response = $"Hello {player.Nickname}";
                return false;
            }
            else
            {
                response = "else";
                return true;
            }
        }
    }
}
