using UnityEngine;

namespace Jam.Game.Movement
{
    public interface IMovementView
    {
        void Move(Vector3 movementDirection);
    }
}