using System;
using UniRx.Triggers;
using UnityEngine;

namespace Jam.Game.Trigger
{
    public class TriggerView : MonoBehaviour, ITriggerView
    {
        public IObservable<Collider> OnCollisionEnter { get; private set; }
        public IObservable<Collider> OnCollisionExit { get; private set; }

        private void Awake()
        {
            var eventTrigger = gameObject.AddComponent<ObservableTriggerTrigger>();
            OnCollisionEnter = eventTrigger.OnTriggerEnterAsObservable();
            OnCollisionExit = eventTrigger.OnTriggerExitAsObservable();
        }
    }
}