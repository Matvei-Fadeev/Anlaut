using AnlautJam.Game.CurrencyHolder;
using AnlautJam.Game.Trigger;
using Core.Installers;
using UnityEngine;

namespace AnlautJam.Game.CollectableProp
{
    public class CollectablePropInstaller : MonoInstaller<CollectablePropMediator, ICollectablePropView, CollectablePropModel>
    {
        [SerializeField] private CollectablePropView collectablePropView;
        [SerializeField] private TriggerView triggerView;
        [SerializeField] private CurrencyHolderView currencyHolderView;
        [SerializeField] private CurrencyHolderModel currencyModel;

        protected override ICollectablePropView View => collectablePropView;

        public override void InstallBindings()
        {
            base.InstallBindings();
            
            TriggerInstaller.InstallBindings(Container, triggerView);
            CurrencyHolderInstaller.InstallBindings(Container, currencyHolderView, currencyModel);
        }
    }
}