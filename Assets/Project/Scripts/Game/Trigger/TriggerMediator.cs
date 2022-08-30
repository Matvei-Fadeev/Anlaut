using System;
using AnlautJam.Game.Player;
using Core.Contexts;
using UniRx;
using UnityEngine;

namespace AnlautJam.Game.Trigger
{
    public class TriggerMediator : Mediator<ITriggerView, TriggerModel>
    {
        public Action<IPlayerView, TriggerType> OnPlayerInTrigger;
        public Action OnTrigger;

        public override void Initialize()
        {
            base.Initialize();
            View.OnCollisionEnter.Subscribe(OnCollisionEnter).AddTo(Disposables);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Player") &&
                collision.gameObject.TryGetComponent(out IPlayerView playerView))
            {
                OnPlayerInTrigger?.Invoke(playerView, TriggerType.OnTriggerEnter);
            }

            OnTrigger?.Invoke();
            Debug.Log(nameof(OnCollisionEnter));
        }
    }
}