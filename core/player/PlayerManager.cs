using System.Collections;
using System.Collections.Generic;

namespace MUDProject.core.player
{
    /// <summary>
    /// 角色托管类
    /// </summary>
    public class PlayerManager
    {
        private uint _playerIdSequence = 1;
        private IDictionary<uint, Player> _playerContainer = new Dictionary<uint, Player>();
        private uint _currentPlayer;
        
        public void Reset()
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