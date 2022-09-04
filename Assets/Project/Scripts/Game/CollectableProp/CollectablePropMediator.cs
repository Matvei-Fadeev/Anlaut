using AnlautJam.Game.CurrencyHolder;
using AnlautJam.Game.Player;
using AnlautJam.Game.Trigger;
using Core.Contexts;
using UnityEngine;

namespace AnlautJam.Game.CollectableProp
{
    public class CollectablePropMediator : Mediator<ICollectablePropView, CollectablePropModel>
    {
        private readonly TriggerMediator _triggerMediator;
        private readonly CurrencyHolderMediator _currencyHolderMediator;

        public CollectablePropMediator(TriggerMediator triggerMediator, CurrencyHolderMediator currencyHolderMediator)
        {
            _triggerMediator = triggerMediator;
            _currencyHolderMediator = currencyHolderMediator;
        }
        
        public override void Initialize()
        {
            base.Initialize();
            _triggerMediator.OnPlayerTriggerEnter += OnPlayerTriggerEnter;
            _triggerMediator.OnPlayerTriggerExit += OnPlayerInTriggerExit;
        }

        public override void Dispose()
        {
            base.Dispose();
            _triggerMediator.OnPlayerTriggerEnter -= OnPlayerTriggerEnter;
            _triggerMediator.OnPlayerTriggerExit -= OnPlayerInTriggerExit;
        }

        private void OnPlayerTriggerEnter(IPlayerView playerView)
        {
            Debug.Log($"CollectablePropMediator.OnPlayerTriggerEnter");
        }

        private void OnPlayerInTriggerExit(IPlayerView playerView)
        {
            Debug.Log($"CollectablePropMediator.OnPlayerInTriggerExit");
        }
    }
}