using Core.Installers;
using UnityEngine;

namespace Jam.Game.UserInput
{
    public class UserInputInstaller : MonoInstaller<UserInputMediator, IUserInputView, UserInputModel>
    {
        [SerializeField] private UserInputView userInputView;

        protected override IUserInputView View => userInputView;
    }
}