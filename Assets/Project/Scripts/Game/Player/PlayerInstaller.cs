using AnlautJam.Game.Movement;
using AnlautJam.Game.Trigger;
using UnityEngine;
using Zenject;

namespace AnlautJam.Game.Player
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private PlayerView playerView;
        [SerializeField] private TriggerView triggerView;
        [SerializeField] private MovementView movementView;

        public override void InstallBindings()
        {
            InstallPlayerBindings(Container);
        }

        public void InstallPlayerBindings(DiContainer diContainer)
        {
            Bind<MovementMediator, IMovementView, MovementModel>(diContainer, movementView);
            Bind<TriggerMediator, ITriggerView, TriggerModel>(diContainer, triggerView);
            Bind<PlayerMediator, IPlayerView, PlayerModel>(diContainer, playerView);
        }

        private static void Bind<TMediator, TView, TModel>(DiContainer diContainer, TView view)
        {
            diContainer.Bind<TModel>().AsSingle();
            diContainer.Bind<TView>().FromInstance(view).AsSingle();
            diContainer.BindInterfacesAndSelfTo<TMediator>().AsSingle();
        }
    }
}