using Core.Installers;
using UnityEngine;

namespace AnlautJam.Game.Trigger
{
    public class TriggerInstaller : MonoInstaller<TriggerMediator, ITriggerView, TriggerModel>
    {
        [SerializeField] private TriggerView triggerView;

        protected override ITriggerView View => triggerView;
    }
}