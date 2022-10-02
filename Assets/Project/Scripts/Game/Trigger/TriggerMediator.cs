using System;
using Core.Contexts;
using Project.Scripts.Game.Constants;
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
            if (TryGetView<PlayerEntity>(collider, Constants.Tags.Player, out var playerView))
                OnPlayerTriggerEnter?.Invoke(playerView);

            Debug.Log(nameof(OnTriggerEnter));
        }

        private void OnTriggerExit(Collider collider)
        {
            if (TryGetView<PlayerEntity>(collider, Constants.Tags.Player, out var playerView))
                OnPlayerTriggerExit?.Invoke(playerView);

            Debug.Log(nameof(OnTriggerExit));
        }

        private static bool TryGetView<T>(Collider collider, string tag, out T view) where T : class
        {
            view = null;
            return collider.CompareTag(tag) &&
                   collider.gameObject.TryGetComponent(out view);
        }
    }
}