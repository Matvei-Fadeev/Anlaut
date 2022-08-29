using Core.Contexts;
using Project.Scripts.Game.Spawner;

namespace AnlautJam.Game.Spawner
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
               
        }
    }
}