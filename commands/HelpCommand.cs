namespace MUDProject.commands
{
    /// <summary>
    /// 帮助命令，但是该怎么跟其他命令关联上呢？
    /// </summary>
    public class HelpCommand: ICommand
    {
        public string GetName()
        {
            return "help";
        }

        public string Execute(string[] fragments)
        {
            return "帮助信息";
        }
    }
}