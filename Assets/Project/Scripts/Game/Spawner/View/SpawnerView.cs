using System.Collections.Generic;
using Project.Scripts.Game.Spawner;
using UnityEngine;

namespace Jam.Game.Spawner
{
    public class SpawnerView : MonoBehaviour, ISpawnerView
    {
        [SerializeField] private SpawnPoint playerSpawnPoint;
        [SerializeField] private List<SpawnPoint> spawnPoints;

        private List<ISpawnPoint> _spawnPoints;

        public ISpawnPoint PlayerSpawnPoint => playerSpawnPoint;
        public List<ISpawnPoint> SpawnPoints => _spawnPoints ??= new List<ISpawnPoint>(spawnPoints);
    }
}