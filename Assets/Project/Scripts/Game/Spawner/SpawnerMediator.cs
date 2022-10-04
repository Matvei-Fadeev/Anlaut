using Core.Contexts;
using Project.Scripts.Game.Player;
using Project.Scripts.Game.Spawner;
using UnityEngine;

namespace Jam.Game.Spawner
{
    public class SpawnerMediator : Mediator<ISpawnerView, SpawnerModel>
    {
        public override void Initialize()
        {
            base.Initialize();
            View.SpawnPoints.ForEach(Spawn);
        }

        private void Spawn(ISpawnPoint spawnPoint)
        {
            Debug.LogError("NotInplemented");
        }

        public void SpawnPlayer(PlayerEntity playerEntity)
        {
            playerEntity.transform.position = View.PlayerSpawnPoint.Position;
        }
    }
}