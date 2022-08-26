using UnityEngine;
using Zenject;

namespace AnlautJam.Game.UserInput
{
    public class UserInputInstaller : MonoInstaller
    {
        [SerializeField] private UserInputView userInputView;

        public override void InstallBindings()
        {
            Container.Bind<UserInputModel>().AsSingle();
            Container.Bind<IUserInputView>().FromInstance(userInputView);
            Container.BindInterfacesTo<UserInputMediator>().AsSingle();
        }
    }
}