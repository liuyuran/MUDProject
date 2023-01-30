using MUDProject.core.bases;

namespace MUDProject.core.player
{
    /// <summary>
    /// 玩家和NPC角色
    /// </summary>
    public class Player: IStatusAble, ILookAble
    {
        private readonly uint _id;
        private Name name;
        private Gender _gender;

        public Player(uint id)
        {
            this._id = id;
            _gender = Gender.Male;
        }

        public new string ToString()
        {
            return $"{_id}:{name}";
        }
        
        public string Status()
        {
            return "角色X";
        }

        public string Look()
        {
            return "你上下打量了一下对方";
        }
    }
}