using System.Collections.Generic;
using System.Linq;
using Project.Scripts.Game.Spawner;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace AnlautJam.Game.Spawner
{
    public class SpawnerView : MonoBehaviour, ISpawnerView
    {
        [SerializeField] private List<SpawnPoint> spawnPoints;

        #if UNITY_EDITOR
        private void OnValidate()
        {
            spawnPoints = gameObject.GetComponentsInChildren<SpawnPoint>().ToList();
            EditorUtility.SetDirty(this);
        }
        #endif

        public List<ISpawnPoint> SpawnPoints { get; }

        public SpawnerView()
        {
            SpawnPoints = new List<ISpawnPoint>(spawnPoints);
        }
    }
}