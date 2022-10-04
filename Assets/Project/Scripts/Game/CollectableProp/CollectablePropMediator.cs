using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Jam.Game.CurrencyHolder;
using Jam.Game.Trigger;
using Core.Contexts;
using Core.Unity;
using Project.Scripts.Game.Currency;
using Project.Scripts.Game.Player;
using UnityEngine;

namespace Jam.Game.CollectableProp
{
    public class CollectablePropMediator : Mediator<ICollectablePropView, CollectablePropModel>
    {
        private readonly TriggerMediator _triggerMediator;
        private readonly CurrencyHolderMediator _currencyHolderMediator;
        private readonly CoroutineRunner _coroutineRunner;
        
        private IEnumerator _collectCurrencyFunc;
        private List<CurrencyValue> _defaultCurrencyValues;

        public CollectablePropMediator(TriggerMediator triggerMediator, CurrencyHolderMediator currencyHolderMediator, CoroutineRunner coroutineRunner)
        {
            _triggerMediator = triggerMediator;
            _currencyHolderMediator = currencyHolderMediator;
            _coroutineRunner = coroutineRunner;
        }
        
        public override void Initialize()
        {
            base.Initialize();
            _triggerMediator.OnPlayerTriggerEnter += OnPlayerTriggerEnter;
            _triggerMediator.OnPlayerTriggerExit += OnPlayerInTriggerExit;

            _defaultCurrencyValues = _currencyHolderMediator.GetCurrency();
            TryToShow();
        }

        public override void Dispose()
        {
            base.Dispose();
            _triggerMediator.OnPlayerTriggerEnter -= OnPlayerTriggerEnter;
            _triggerMediator.OnPlayerTriggerExit -= OnPlayerInTriggerExit;
        }

        private void OnPlayerTriggerEnter(PlayerEntity playerEntity)
        {
            StartCollecting(playerEntity);
        }

        private void OnPlayerInTriggerExit(PlayerEntity playerEntity)
        {
            StopCollecting();
        }

        private void StartCollecting(PlayerEntity playerEntity)
        {
            StopCollecting();
            _collectCurrencyFunc = CollectCurrency(playerEntity);
            _coroutineRunner.StartCoroutine(_collectCurrencyFunc);
        }

        private void StopCollecting()
        {
            if (_collectCurrencyFunc != null)
            {
                _coroutineRunner.StopCoroutine(_collectCurrencyFunc);
                _collectCurrencyFunc = null;
            }
        }

        private IEnumerator CollectCurrency(PlayerEntity playerEntity)
        {
            var waitForSeconds = new WaitForSeconds(Model.collectingDelay);

            while (_currencyHolderMediator.HasAny())
            {
                yield return waitForSeconds;

                var currencyValue = Model.currencyChangeOnPlayerInTrigger;
                var currencyHolderValue = _currencyHolderMediator.GetCurrency(currencyValue.currencyType);
                if (currencyHolderValue.amount < currencyValue.amount)
                    currencyValue = currencyHolderValue;

                if (!_currencyHolderMediator.TryRemoveCurrency(currencyValue)) 
                    continue;
                
                var playerCurrencyHolderMediator = playerEntity.Get<ICurrencyHolderMediator>();
                playerCurrencyHolderMediator.TryAddCurrency(currencyValue);
            }

            View.Hide();
            _coroutineRunner.StartCoroutine(RestoreWithDelay());
        }

        private IEnumerator RestoreWithDelay()
        {
            var waitForSeconds = new WaitForSeconds(Model.respawnDelay);
            yield return waitForSeconds;

            _defaultCurrencyValues.ForEach(x => _currencyHolderMediator.TryAddCurrency(x));
            TryToShow();
        }

        private void TryToShow()
        {
            if (_currencyHolderMediator.HasAny())
                View.Show();
        }
    }
}