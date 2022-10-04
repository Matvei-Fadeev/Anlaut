using System;
using Core.Contexts;
using Project.Scripts.Game.Player;
using UniRx;
using UnityEngine;

namespace Jam.Game.Trigger
{
    public class TriggerMediator : Mediator<ITriggerView, TriggerModel>
    {
        public event Action<PlayerEntity> OnPlayerTriggerEnter;
        public event Action<PlayerEntity> OnPlayerTriggerExit;

        public override void Initialize()
        {
            base.Initialize();
            View.OnCollisionEnter.Subscribe(OnTriggerEnter).AddTo(Disposables);
            View.OnCollisionExit.Subscribe(OnTriggerExit).AddTo(Disposables);
        }

        private void OnTriggerEnter(Collider collider)
        {
            if (!collider.TryGetComponent(out ITriggerView triggerView))
                return;

            if (triggerView.Entity is PlayerEntity playerEntity) 
                OnPlayerTriggerEnter?.Invoke(playerEntity);

            Debug.Log(nameof(OnTriggerEnter));
        }

        private void OnTriggerExit(Collider collider)
        {
            if (!collider.TryGetComponent(out ITriggerView triggerView))
                return;

            if (triggerView.Entity is PlayerEntity playerEntity) 
                OnPlayerTriggerExit?.Invoke(playerEntity);

            Debug.Log(nameof(OnTriggerExit));
        }
    }
}