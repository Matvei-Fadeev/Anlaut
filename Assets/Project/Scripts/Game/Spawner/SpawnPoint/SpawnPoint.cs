using UnityEngine;

namespace Project.Scripts.Game.Spawner
{
    public class SpawnPoint : MonoBehaviour, ISpawnPoint
    {
        [SerializeField] private string id;
        
        public string Id => id;
        public Vector3 Position => transform.position;
        public Quaternion Rotation => transform.rotation;
    }
}