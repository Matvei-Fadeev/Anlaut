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
            Bind<MovementMediator, IMovementView, MovementModel>(movementView);
            Bind<TriggerMediator, ITriggerView, TriggerModel>(triggerView);
            Bind<PlayerMediator, IPlayerView, PlayerModel>(playerView);
        }

        private void Bind<TMediator, TView, TModel>(TView view)
        {
            Container.Bind<TModel>().AsSingle();
            Container.Bind<TView>().FromInstance(view).AsSingle();
            Container.BindInterfacesAndSelfTo<TMediator>().AsSingle();
        }
    }
}