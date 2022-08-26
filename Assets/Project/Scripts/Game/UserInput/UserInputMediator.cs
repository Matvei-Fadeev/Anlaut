using System;
using Core.Contexts;
using UnityEngine;
using Zenject;

namespace AnlautJam.Game.UserInput
{
    public partial class UserInputMediator : Mediator
    {
        [Inject] private readonly IUserInputView _userInputView;
        [Inject] private readonly UserInputModel _userInputModel;

        public override void Initialize()
        {
            base.Initialize();
            _userInputView.OnUserAxis += input => OnUserAxisInput?.Invoke(input);
        }
        
        public event Action<Vector3> OnUserAxisInput;
    }
}