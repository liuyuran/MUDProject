using MUDProject.core.bases;
using MUDProject.core.enums;

namespace MUDProject.core.player
{
    /// <summary>
    /// 玩家和NPC角色
    /// </summary>
    public class Player: IStatusAble, ILookAble
    {
        private readonly uint _id;
        public Name Name;
        public Gender Gender;
        public IRace Race;
        public readonly RelationshipManager RelationshipManager;

        public Player(uint id)
        {
            _id = id;
            Gender = Gender.Male;
            RelationshipManager = new RelationshipManager(this);
        }
        
        public string Status()
        {
            return "角色X";
        }

        public string Look(Player from)
        {
            return $"你上下打量了一下，这是一{Race.GetDimension()}{Race.GetRaceName(Gender)}。";
        }
    }
}