using Jam.Game.CurrencyHolder;
using Jam.Game.Trigger;
using Core.Contexts;
using Project.Scripts.Game.Player;
using UnityEngine;

namespace Jam.Game.CollectableProp
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

        private void OnPlayerTriggerEnter(PlayerEntity playerEntity)
        {
            var currencyValue = Model.CurrencyChangeOnPlayerInTrigger;
            var currencyHolderMediator = playerEntity.Get<ICurrencyHolderMediator>();
            currencyHolderMediator.ChangeCurrency(currencyValue);
        }

        private void OnPlayerInTriggerExit(PlayerEntity playerEntity)
        {
            Debug.Log($"CollectablePropMediator.OnPlayerInTriggerExit");
        }
    }
}