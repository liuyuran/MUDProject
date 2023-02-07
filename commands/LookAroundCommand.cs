using System;
using MUDProject.core.player;
using MUDProject.core.world;

namespace MUDProject.commands
{
    /// <summary>
    /// 角色相关指令
    /// </summary>
    public class LookAroundCommand: ICommand
    {
        public string GetName()
        {
            return "lookAround";
        }

        public string Execute(string[] fragments)
        {
            return World.Instant.MapManager.Look(World.Instant.PlayerManager.GetCurrentPlayer());
        }

        public string Help(bool explain)
        {
            return $"{GetName()}: 看向周围";
        }
    }
}