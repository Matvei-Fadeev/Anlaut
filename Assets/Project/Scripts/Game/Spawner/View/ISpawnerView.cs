using System.Collections.Generic;
using Project.Scripts.Game.Spawner;

namespace AnlautJam.Game.Spawner
{
    public interface ISpawnerView
    {
        List<ISpawnPoint> SpawnPoints { get; }
    }
}