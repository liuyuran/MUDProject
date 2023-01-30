using MUDProject.core.world;

namespace MUDProject.commands
{
    /// <summary>
    /// 角色相关指令
    /// </summary>
    public class StatusCommand: ICommand
    {
        public string GetName()
        {
            return "status";
        }

        public string Execute(string[] fragments, World world)
        {
            return "帮助信息";
        }

        public string Help(bool explain)
        {
            if (!explain) return "status: 查询角色状态";
            return "详情";
        }
    }
}