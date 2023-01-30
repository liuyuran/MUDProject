using MUDProject.core.world;

namespace MUDProject.commands
{
    /// <summary>
    /// 可执行命令的抽象接口
    /// </summary>
    public interface ICommand
    {
        string GetName();
        string Execute(string[] fragments, World world);
        string Help(bool explain);
    }
}