using System;
using UniRx.Triggers;
using UnityEngine;

namespace AnlautJam.Game.Trigger
{
    public class TriggerView : MonoBehaviour, ITriggerView
    {
        public IObservable<Collision> OnCollisionEnter { get; private set; }
        public IObservable<Collision> OnCollisionExit { get; private set; }

        private void Start()
        {
            var eventTrigger = gameObject.AddComponent<ObservableCollisionTrigger>();
            OnCollisionEnter = eventTrigger.OnCollisionEnterAsObservable();
            OnCollisionExit = eventTrigger.OnCollisionExitAsObservable();
        }
    }
}