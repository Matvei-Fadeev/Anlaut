using System;
using UnityEngine;

namespace AnlautJam.Game.Trigger
{
    [RequireComponent(typeof(Collider))]
    public class TriggerView : MonoBehaviour, ITriggerView
    {
        private void OnTriggerEnter(Collider other)
        {
            OnTrigger?.Invoke(other, TriggerType.OnTriggerEnter);
        }

        public event Action<Collider, TriggerType> OnTrigger;
    }
}