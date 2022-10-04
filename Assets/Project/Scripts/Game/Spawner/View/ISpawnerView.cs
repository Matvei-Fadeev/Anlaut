using System.Collections.Generic;
using Project.Scripts.Game.Spawner;

namespace Jam.Game.Spawner
{
    public interface ISpawnerView
    {
        ISpawnPoint PlayerSpawnPoint { get; }
        List<ISpawnPoint> SpawnPoints { get; }
    }
}