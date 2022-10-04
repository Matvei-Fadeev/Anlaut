using UnityEngine;

namespace Project.Scripts.Game.Spawner
{
    public interface ISpawnPoint
    {
        string Id { get; }
        Vector3 Position { get; }
        Quaternion Rotation { get; }
    }
}