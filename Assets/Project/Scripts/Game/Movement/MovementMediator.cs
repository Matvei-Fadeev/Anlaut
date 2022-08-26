using AnlautJam.Game.UserInput;
using Core.Contexts.FSM;
using UnityEngine;
using Zenject;

namespace AnlautJam.Game.Movement
{
    public partial class MovementMediator : StateMachineMediator
    {
        [Inject] private readonly IMovementView _movementView;
        [Inject] private readonly MovementModel _movementModel;

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
            _movementView.Move(movementDirection);
        }
    }
}