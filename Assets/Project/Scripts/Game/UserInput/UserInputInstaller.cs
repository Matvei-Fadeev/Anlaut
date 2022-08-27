using Core.Installers;
using UnityEngine;

namespace AnlautJam.Game.UserInput
{
    public class UserInputInstaller : ContextInstaller<UserInputMediator, IUserInputView, UserInputModel>
    {
        [SerializeField] private UserInputView userInputView;

        protected override IUserInputView View => userInputView;
    }
}