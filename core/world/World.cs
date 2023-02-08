using MUDProject.core.map;
using MUDProject.core.player;

namespace MUDProject.core.world
{
    /// <summary>
    /// 世界类，在核心包中，托管所有全局变量
    /// </summary>
    public class World
    {
        // 没必要用rust式语法找不痛快，静态单例最棒了
        public static readonly World Instant = new World();
        
        public readonly PlayerManager PlayerManager = new PlayerManager();
        public readonly MapManager MapManager;

        public World()
        {
            ReInit();
            MapManager = new MapManager(PlayerManager.GetCurrentPlayer());
        }

        public void ReInit()
        {
            PlayerManager.Reset();
        }
    }
}