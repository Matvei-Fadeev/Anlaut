using AnlautJam.Game.Movement;
using AnlautJam.Game.Trigger;
using Project.Scripts.Game.Player.View;
using UnityEngine;
using Zenject;

namespace Project.Scripts.Game.Player
{
    public class PlayerInstaller : Core.Installers.MonoInstaller<PlayerMediator, IPlayerView, PlayerModel>
    {
        [SerializeField] private PlayerFacade playerFacade;

        protected override IPlayerView View => playerFacade.PlayerView;

        public override void InstallBindings(DiContainer diContainer)
        {
            MovementInstaller.InstallBindings(diContainer, playerFacade.MovementView);
            TriggerInstaller.InstallBindings(diContainer, playerFacade.TriggerView);
        }
    }
}