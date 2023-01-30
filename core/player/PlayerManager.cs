namespace MUDProject.core.player
{
    /// <summary>
    /// 角色托管类
    /// </summary>
    public class PlayerManager
    {
        private uint _playerIdSequence = 1;
        private Player _currentPlayer;
        
        public void Reset()
        {
            _playerIdSequence = 1;
            _currentPlayer = GeneratePlayer();
        }

        private Player GeneratePlayer()
        {
            return new Player(_playerIdSequence++);
        }

        public Player GetCurrentPlayer()
        {
            return _currentPlayer;
        }
    }
}