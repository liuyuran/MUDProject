using System;
using MUDProject.core.player;
using MUDProject.core.world;

namespace MUDProject.commands
{
    /// <summary>
    /// 角色相关指令
    /// </summary>
    public class LookAtCommand: ICommand
    {
        public string GetName()
        {
            return "lookAt";
        }

        public string Execute(string[] fragments)
        {
            Player target;
            if (fragments.Length != 1)
                return "lookAt命令应当如此使用: lookAt <self|角色id>";
            switch (fragments[0])
            {
                case "self":
                    target = World.Instant.PlayerManager.GetCurrentPlayer();
                    break;
                default:
                    try
                    {
                        target = World.Instant.PlayerManager.GetPlayerById(Convert.ToUInt32(fragments[0]));
                    } catch (Exception)
                    {
                        return $"无效的二级指令{fragments[0]}";
                    }
                    break;
            }

            return target.Look(World.Instant.PlayerManager.GetCurrentPlayer());
        }

        public string Help(bool explain)
        {
            return $"{GetName()}: 看向某人";
        }
    }
}