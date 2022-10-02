using UnityEngine;

namespace Jam.Game.CollectableProp
{
    public class CollectablePropInstaller : Core.Installers.MonoInstaller<CollectablePropMediator, ICollectablePropView, CollectablePropModel>
    {
        [SerializeField] private CollectablePropView collectablePropView;

        protected override ICollectablePropView View => collectablePropView;
    }
}