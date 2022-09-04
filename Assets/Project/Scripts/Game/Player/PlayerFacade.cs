using Jam.Game.Movement;
using Jam.Game.Trigger;
using Core.Unity;
using Project.Scripts.Game.Player.View;
using UnityEngine;

namespace Project.Scripts.Game.Player
{
    public class PlayerFacade : AFacade
    {
        [SerializeField] private PlayerView playerView;
        [SerializeField] private TriggerView triggerView;
        [SerializeField] private MovementView movementView;
        
        public IPlayerView PlayerView => playerView;
        public ITriggerView TriggerView => triggerView;
        public IMovementView MovementView => movementView;

        private void OnValidate()
        {
            Validate(ref playerView);
            Validate(ref triggerView);
            Validate(ref movementView);
        }
    }
}