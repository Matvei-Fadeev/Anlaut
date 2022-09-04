using System.Collections.Generic;
using Project.Scripts.Game.Spawner;

namespace Jam.Game.Spawner
{
    public interface ISpawnerView
    {
        List<ISpawnPoint> SpawnPoints { get; }
    }
}