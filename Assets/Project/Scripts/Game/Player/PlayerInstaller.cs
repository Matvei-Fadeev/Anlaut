using Project.Scripts.Game.Player.View;
using UnityEngine;

namespace Project.Scripts.Game.Player
{
    public class PlayerInstaller : Core.Installers.MonoInstaller<PlayerMediator, IPlayerView, PlayerModel>
    {
        [SerializeField] private PlayerView playerView;

        protected override IPlayerView View => playerView;
    }
}