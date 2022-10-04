using Jam.Game.CurrencyHolder;
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
        
        [Inject] private CurrencyHolderView _currencyHolderView;
        
        public override void InstallBindings()
        {
            Container.BindInstance(movementModel);
            var playerEntity = Container.InstantiatePrefabForComponent<PlayerEntity>(playerPrefab);
            playerEntity.Construct(_currencyHolderView);
            playerEntity.InstallBindings(Container);
            Container.BindInstance(playerEntity);
        }
    }
}