using System;
using Jam.Game.CollectableProp;
using Jam.Game.CurrencyHolder;
using Jam.Game.Trigger;
using Core.Unity;
using UnityEngine;

namespace Project.Scripts.Game.CollectableProp
{
    public class CollectablePropFacade : AFacade
    {
        [SerializeField] private CollectablePropView collectablePropView;
        [SerializeField] private TriggerView triggerView;
        [SerializeField] private CurrencyHolderView currencyHolderView;
        [SerializeField] private CurrencyHolderModel currencyModel;

        public ICollectablePropView CollectablePropView => collectablePropView;
        public ITriggerView TriggerView => triggerView;
        public ICurrencyHolderView CurrencyHolderView => currencyHolderView;
        public CurrencyHolderModel CurrencyHolderModel => currencyModel;

        private void OnValidate()
        {
            Validate(ref collectablePropView);
            Validate(ref triggerView);
            Validate(ref currencyHolderView);
        }
    }
}