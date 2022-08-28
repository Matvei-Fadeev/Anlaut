using AnlautJam.Game.UserInput;
using Core.Contexts;
using UnityEngine;
using Zenject;

namespace AnlautJam.Game.Movement
{
    public class MovementMediator : Mediator<IMovementView, MovementModel>
    {
        [Inject] private readonly UserInputMediator _userInputMediator;

        public override void Initialize()
        {
            base.Initialize();
            _userInputMediator.OnUserAxisInput += Move;
        }

        public override void Dispose()
        {
            base.Dispose();
            _userInputMediator.OnUserAxisInput -= Move;
        }

        private void Move(Vector3 movementDirection)
        {
            View.Move(movementDirection);
        }
    }
}