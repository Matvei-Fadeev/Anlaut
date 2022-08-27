using System;
using Core.Contexts;
using UnityEngine;

namespace AnlautJam.Game.UserInput
{
    public class UserInputMediator : Mediator<IUserInputView, UserInputModel>
    {
        public override void Initialize()
        {
            base.Initialize();
            View.OnUserAxis += input => OnUserAxisInput?.Invoke(input);
        }
        
        public event Action<Vector3> OnUserAxisInput;
    }
}