using System;
using System.Collections.Generic;
using MUDProject.commands;

namespace MUDProject
{
    /// <summary>
    /// 用于注册命令并分派执行
    /// </summary>
    public class CommandManager
    {
        private readonly IDictionary<string, ICommand> _commandList = new Dictionary<string, ICommand>();

        public CommandManager()
        {
            RegistryCommand(new HelpCommand());
        }

        private void RegistryCommand(ICommand command)
        {
            _commandList[command.GetName()] = command;
        }
        
        public string Execute(string command)
        {
            var fragments = command.Split(' ');
            var firstLevel = fragments[0];
            return !_commandList.ContainsKey(firstLevel) ? $"未注册的指令: {firstLevel}" : _commandList[firstLevel].Execute(fragments);
        }
    }
}