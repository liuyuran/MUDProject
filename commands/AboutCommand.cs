using System;
using MUDProject.core.player;
using MUDProject.core.world;

namespace MUDProject.commands
{
    /// <summary>
    /// 关于指令，内置版权声明
    /// </summary>
    public class AboutCommand : ICommand
    {
        public string GetName()
        {
            return "about";
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
            return !explain ? $"{GetName()}: 关于" : "不存在二级指令";
        }
    }
}