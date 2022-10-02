using Jam.Game.CollectableProp;
using Jam.Game.CurrencyHolder;
using Jam.Game.Trigger;
using Core.Unity;
using UnityEngine;
using Zenject;

namespace Project.Scripts.Game.CollectableProp
{
    public class CollectablePropEntity : Entity
    {
        [SerializeField] private CollectablePropView collectablePropView;
        [SerializeField] private TriggerView triggerView;
        [SerializeField] private CurrencyHolderView currencyHolderView;
        [SerializeField] private CurrencyHolderModel currencyModel;

        private void OnValidate()
        {
            Validate(ref collectablePropView);
            Validate(ref triggerView);
            Validate(ref currencyHolderView);
        }

        public override void InstallBindings(DiContainer diContainer)
        {
            base.InstallBindings(diContainer);
            CollectablePropInstaller.InstallBindings(diContainer, collectablePropView);
            TriggerInstaller.InstallBindings(diContainer, triggerView);
            CurrencyHolderInstaller.InstallBindings(diContainer, currencyHolderView, currencyModel);
        }
    }
}