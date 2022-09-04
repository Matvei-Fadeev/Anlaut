using AnlautJam.Game.Movement;
using AnlautJam.Game.Trigger;
using UnityEngine;
using Zenject;

namespace AnlautJam.Game.Player
{
    public class PlayerInstaller : Core.Installers.MonoInstaller<PlayerMediator, IPlayerView, PlayerModel>
    {
        [SerializeField] private PlayerView playerView;
        [SerializeField] private TriggerView triggerView;
        [SerializeField] private MovementView movementView;

        protected override IPlayerView View => playerView;

        public override void InstallBindings(DiContainer diContainer)
        {
            MovementInstaller.InstallBindings(diContainer, movementView);
            TriggerInstaller.InstallBindings(diContainer, triggerView);
        }
    }
}