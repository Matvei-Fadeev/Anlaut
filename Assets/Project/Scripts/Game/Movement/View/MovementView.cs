using UnityEngine;

namespace Jam.Game.Movement
{
    public class MovementView : MonoBehaviour, IMovementView
    {
        [SerializeField] private CharacterController characterController;

        public void Move(Vector3 movementDirection)
        {
            characterController.SimpleMove(movementDirection);
        }
    }
}