using System.Collections.Generic;
using Project.Scripts.Game.Spawner;
using UnityEngine;
using Zenject;

namespace Jam.Game.Spawner
{
    public class SpawnerView : MonoBehaviour, ISpawnerView
    {
        [SerializeField] private List<SpawnPoint> spawnPoints;

        public List<ISpawnPoint> SpawnPoints { get; private set; }
        
        [Inject]        
        public void Construct()
        {
            SpawnPoints = new List<ISpawnPoint>(spawnPoints);
        }
    }
}