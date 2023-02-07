using MUDProject.core.player;

namespace MUDProject.core.bases
{
    public abstract class BaseManager
    {
        protected readonly Player Player;

        protected BaseManager(Player player)
        {
            Player = player;
        }

        /// <summary>
        /// 重置一切状态
        /// </summary>
        public abstract void Reset();
    }
}