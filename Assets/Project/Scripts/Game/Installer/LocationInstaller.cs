using AnlautJam.Game.Player;
using UnityEngine;
using Zenject;

namespace Project.Scripts.Game.Installer
{
    public class LocationInstaller : MonoInstaller
    {
        [SerializeField] private GameObject playerPrefab;
        
        public override void InstallBindings()
        {
            var playerInstaller = Container.InstantiatePrefabForComponent<PlayerInstaller>(playerPrefab);
            playerInstaller.InstallPlayerBindings(Container);
        }
    }
}