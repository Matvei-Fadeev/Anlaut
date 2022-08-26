using UnityEngine;
using Zenject;

namespace AnlautJam.Game.Movement
{
    public class MovementInstaller : MonoInstaller
    {
        [SerializeField] private MovementView movementView;

        public override void InstallBindings()
        {
            Container.Bind<MovementModel>().AsSingle();
            Container.Bind<IMovementView>().FromInstance(movementView);
            Container.BindInterfacesTo<MovementMediator>().AsSingle();
        }
    }
}