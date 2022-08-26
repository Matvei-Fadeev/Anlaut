using UniRx;
using UnityEngine;

namespace AnlautJam.Game.Movement
{
    public class MovementView : MonoBehaviour, IMovementView
    {
        [SerializeField] private CharacterController characterController;
        [SerializeField] private Rigidbody rigidbody;

        public void Move(Vector3 movementDirection)
        {
            characterController.SimpleMove(movementDirection);
        }

        private void Start()
        {
            
        }
    }
}