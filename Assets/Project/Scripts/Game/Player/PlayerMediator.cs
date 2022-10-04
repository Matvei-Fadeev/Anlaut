using Core.Contexts;
using Jam.Game.Spawner;
using Project.Scripts.Game.Player.View;
using Zenject;

namespace Project.Scripts.Game.Player
{
    public class PlayerMediator : Mediator<IPlayerView, PlayerModel>
    {
        [Inject] private SpawnerMediator _spawnerMediator;
        [Inject] private PlayerEntity _playerEntity;
        
        public override void Initialize()
        {
            base.Initialize();
            _spawnerMediator.SpawnPlayer(_playerEntity);
        }
    }
}