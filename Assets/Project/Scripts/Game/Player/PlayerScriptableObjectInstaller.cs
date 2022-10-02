using Jam.Game.Movement;
using UnityEngine;
using Zenject;

namespace Project.Scripts.Game.Player
{
    [CreateAssetMenu(fileName = nameof(PlayerScriptableObjectInstaller), menuName = "Installers/" + nameof(PlayerScriptableObjectInstaller))]
    public class PlayerScriptableObjectInstaller : ScriptableObjectInstaller<PlayerScriptableObjectInstaller>
    {
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private MovementModel movementModel;
        
        public override void InstallBindings()
        {
            Container.BindInstance(movementModel);
            
            var playerInstaller = Container.InstantiatePrefabForComponent<PlayerEntity>(playerPrefab);
            playerInstaller.InstallBindings(Container);
        }
    }
}