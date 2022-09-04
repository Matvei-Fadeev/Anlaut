using Core.Installers;
using UnityEngine;

namespace Jam.Game.Trigger
{
    public class TriggerInstaller : MonoInstaller<TriggerMediator, ITriggerView, TriggerModel>
    {
        [SerializeField] private TriggerView triggerView;

        protected override ITriggerView View => triggerView;
    }
}