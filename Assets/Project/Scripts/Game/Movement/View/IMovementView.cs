using UnityEngine;

namespace AnlautJam.Game.Movement
{
    public interface IMovementView
    {
        void Move(Vector3 movementDirection);
    }
}