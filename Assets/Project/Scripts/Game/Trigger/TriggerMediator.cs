using System;
using AnlautJam.Game.Player;
using Core.Contexts;
using Project.Scripts.Game.Constants;
using UniRx;
using UnityEngine;

namespace AnlautJam.Game.Trigger
{
    public class TriggerMediator : Mediator<ITriggerView, TriggerModel>
    {
        public event Action<IPlayerView> OnPlayerTriggerEnter;
        public event Action<IPlayerView> OnPlayerTriggerExit;

        public override void Initialize()
        {
            base.Initialize();
            View.OnCollisionEnter.Subscribe(OnCollisionEnter).AddTo(Disposables);
            View.OnCollisionExit.Subscribe(OnCollisionExit).AddTo(Disposables);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (TryGetView<IPlayerView>(collision, Constants.Tags.Player, out var playerView))
                OnPlayerTriggerEnter?.Invoke(playerView);

            Debug.Log(nameof(OnCollisionEnter));
        }

        private void OnCollisionExit(Collision collision)
        {
            if (TryGetView<IPlayerView>(collision, Constants.Tags.Player, out var playerView))
                OnPlayerTriggerExit?.Invoke(playerView);

            Debug.Log(nameof(OnCollisionExit));
        }

        private static bool TryGetView<T>(Collision collision, string tag, out T view) where T : class
        {
            view = null;
            return collision.collider.CompareTag(tag) &&
                   collision.gameObject.TryGetComponent(out view);
        }
    }
}