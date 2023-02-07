using MUDProject.core.bases;
using MUDProject.core.enums;

namespace MUDProject.core.player
{
    public class RelationshipManager: BaseManager
    {
        public RelationshipManager(Player player) : base(player)
        {
        }
        
        /// <summary>
        /// 与另一个角色之间的关系
        /// </summary>
        /// <param name="player">目标角色</param>
        /// <returns>关系枚举值</returns>
        public Relationship WithPlayer(Player player)
        {
            if (player == Player) return Relationship.Self;
            return Relationship.Stranger;
        }

        public override void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}