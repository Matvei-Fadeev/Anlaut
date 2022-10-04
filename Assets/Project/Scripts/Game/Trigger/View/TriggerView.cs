using System;
using Core.Unity;
using UniRx.Triggers;
using UnityEngine;

namespace Jam.Game.Trigger
{
    public class TriggerView : MonoBehaviour, ITriggerView
    {
        [SerializeField] private Entity entity;
        
        public IObservable<Collider> OnCollisionEnter { get; private set; }
        public IObservable<Collider> OnCollisionExit { get; private set; }
        public Entity Entity => entity;

        private void Awake()
        {
            var eventTrigger = gameObject.AddComponent<ObservableTriggerTrigger>();
            OnCollisionEnter = eventTrigger.OnTriggerEnterAsObservable();
            OnCollisionExit = eventTrigger.OnTriggerExitAsObservable();
        }
    }
}