using System;
using MUDProject.core.world;

namespace MUDProject
{
    internal static class Program
    {
        private static readonly CommandManager CommandManager = new CommandManager();
        
        public static void Main(string[] args)
        {
            var world = new World();
            world.ReInit();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == null || command.Trim().Length == 0) continue;
                if (command == "exit") break;
                Console.WriteLine(CommandManager.Execute(command, world));
            }
        }
    }
}