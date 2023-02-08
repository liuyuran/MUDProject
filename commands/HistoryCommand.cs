using System;
using MUDProject.core.player;
using MUDProject.core.world;

namespace MUDProject.commands
{
    /// <summary>
    /// 历史指令，陈述背景故事
    /// </summary>
    public class HistoryCommand : ICommand
    {
        public string GetName()
        {
            return "history";
        }

        public string Execute(string[] fragments)
        {
            if (fragments.Length >= 1)
                return "about命令不存在二级指令";
            return string.Join(
                Environment.NewLine,
                "The",
                "quick",
                "brown",
                "fox...");
            ;
        }

        public string Help(bool explain)
        {
            return !explain ? $"{GetName()}: 历史背景" : "不存在二级指令";
        }
    }
}