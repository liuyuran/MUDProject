using System.Collections.Generic;
using MUDProject.core.bases;

namespace MUDProject.core.player
{
    /// <summary>
    /// 角色托管类，目前功能只有存储和获取角色实例，其他操作都在角色对象上
    /// </summary>
    public class PlayerManager: BaseManager
    {
        private uint _playerIdSequence = 1;
        private readonly IDictionary<uint, Player> _playerContainer = new Dictionary<uint, Player>();
        private uint _currentPlayer;
        
        public PlayerManager() : base(null)
        {
        }
        
        public override void Reset()
        {
            _playerIdSequence = 1;
            _currentPlayer = GeneratePlayer();
        }

        private uint GeneratePlayer()
        {
            var id = _playerIdSequence++;
            _playerContainer[id] = new Player(id);
            return id;
        }

        public Player GetCurrentPlayer()
        {
            return GetPlayerById(_currentPlayer);
        }

        public Player GetPlayerById(uint id)
        {
            return _playerContainer[id];
        }
    }
}