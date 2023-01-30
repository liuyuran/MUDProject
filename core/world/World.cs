using MUDProject.core.player;

namespace MUDProject.core.world
{
    /// <summary>
    /// 世界类，在核心包中，托管所有全局变量
    /// </summary>
    public class World
    {
        public readonly PlayerManager PlayerManager = new PlayerManager();
        
        public World()
        {
        }

        public void ReInit()
        {
            PlayerManager.Reset();
        }
    }
}