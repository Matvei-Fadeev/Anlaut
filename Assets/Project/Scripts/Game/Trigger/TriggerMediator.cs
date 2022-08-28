using System;
using AnlautJam.Game.Player;
using Core.Contexts;
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
            View.OnTriggerEnterEvent += OnTriggerEnterEvent;
        }

        public override void Dispose()
        {
            base.Dispose();
            View.OnTriggerEnterEvent -= OnTriggerEnterEvent;
        }

        private void OnTriggerEnterEvent(Collider collider)
        {
            if (collider.CompareTag("Player") && collider.TryGetComponent(out IPlayerView playerView))
            {
                OnPlayerInTrigger?.Invoke(playerView, TriggerType.OnTriggerEnter);
            }
            
            OnTrigger?.Invoke();
        }
    }
}