using System;
using MUDProject.core.world;

namespace MUDProject
{
    internal static class Program
    {
        private static readonly CommandManager CommandManager = new CommandManager();
        
        public static void Main(string[] args)
        {
            World.Instant.ReInit();
            Console.WriteLine("欢迎使用MUD环境测试工程");
            Console.WriteLine("该工程用于使用现代编程思想重新探索MUD游戏实现的可能性");
            Console.WriteLine("如果不熟悉系统命令，请输入help获取帮助");
            while (true)
            {
                var command = Console.ReadLine();
                if (command == null || command.Trim().Length == 0) continue;
                if (command == "exit") break;
                Console.WriteLine(CommandManager.Execute(command));
            }
        }
    }
}