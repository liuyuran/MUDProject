using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            var assem = typeof(ICommand).Assembly;
            var baseType = typeof(ICommand);
            var types = assem.GetExportedTypes();
            foreach (var type in types)
            {
                if (type.IsInterface || type.FullName == null) continue;
                if (type.GetInterface(baseType.FullName) != baseType) continue;
                RegistryCommand(assem.CreateInstance(type.FullName, false,
                    BindingFlags.ExactBinding,
                    null, new object[] {}, null, null) as ICommand);
            }
        }

        private void RegistryCommand(ICommand command)
        {
            _commandList[command.GetName()] = command;
        }

        public string Execute(string command)
        {
            var fragments = command.Split(' ');
            var firstLevel = fragments[0];
            if (firstLevel != "help")
            {
                var fragment = fragments.ToList();
                fragment.RemoveAt(0);
                return !_commandList.ContainsKey(firstLevel)
                    ? $"未注册的一级指令: {firstLevel}"
                    : _commandList[firstLevel].Execute(fragment.ToArray());
            }

            if (fragments.Length == 2)
                return !_commandList.ContainsKey(fragments[1])
                    ? $"未注册的一级指令: {fragments[1]}"
                    : _commandList[fragments[1]].Help(true);
            if (fragments.Length > 2)
                return "help指令不支持二级指令及以上的查询";
            var result = "使用【help <一级指令>】获取更详细的帮助\n";
            result += _commandList.Values.ToList()
                .Aggregate("", (current, commandItem) => current + "\n" + commandItem.Help(false));
            return result;
        }
    }
}