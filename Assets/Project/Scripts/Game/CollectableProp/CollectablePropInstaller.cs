using Jam.Game.CurrencyHolder;
using Jam.Game.Trigger;
using Project.Scripts.Game.CollectableProp;
using UnityEngine;
using Zenject;

namespace Jam.Game.CollectableProp
{
    public class CollectablePropInstaller : Core.Installers.MonoInstaller<CollectablePropMediator, ICollectablePropView, CollectablePropModel>
    {
        [SerializeField] private CollectablePropFacade collectablePropFacade;

        protected override ICollectablePropView View => collectablePropFacade.CollectablePropView;

        public override void InstallBindings(DiContainer diContainer)
        {
            TriggerInstaller.InstallBindings(diContainer, collectablePropFacade.TriggerView);
            CurrencyHolderInstaller.InstallBindings(diContainer, collectablePropFacade.CurrencyHolderView, collectablePropFacade.CurrencyHolderModel);
        }
    }
}