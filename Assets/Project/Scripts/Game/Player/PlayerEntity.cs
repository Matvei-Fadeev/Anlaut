using Core.Unity;
using Jam.Game.CurrencyHolder;
using Jam.Game.Movement;
using Jam.Game.Trigger;
using Project.Scripts.Game.Player.View;
using UnityEngine;
using Zenject;

namespace Project.Scripts.Game.Player
{
    public class PlayerEntity : Entity
    {
        [SerializeField] private PlayerView playerView;
        [SerializeField] private TriggerView triggerView;
        [SerializeField] private MovementView movementView;

        private CurrencyHolderView _currencyHolderView;

        public void Construct(CurrencyHolderView currencyHolderView)
        {
            _currencyHolderView = currencyHolderView;
        }

        private void OnValidate()
        {
            Validate(ref playerView);
            Validate(ref triggerView);
            Validate(ref movementView);
        }

        public override void InstallBindings(DiContainer diContainer)
        {
            base.InstallBindings(diContainer);
            PlayerInstaller.InstallBindings(diContainer, playerView);
            MovementInstaller.InstallBindings(diContainer, movementView);
            TriggerInstaller.InstallBindings(diContainer, triggerView);
            CurrencyHolderInstaller.InstallBindings(diContainer, _currencyHolderView);
        }
    }
}