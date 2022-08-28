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
            View.OnTrigger += OnTriggerEnter;
        }

        public override void Dispose()
        {
            base.Dispose();
            View.OnTrigger -= OnTriggerEnter;
        }

        private void OnTriggerEnter(Collider collider, TriggerType triggerType)
        {
            if (collider.CompareTag("Player") && collider.TryGetComponent(out IPlayerView playerView))
            {
                OnPlayerInTrigger?.Invoke(playerView, triggerType);
            }
            
            OnTrigger?.Invoke();
        }
    }
}