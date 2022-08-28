using System;
using UnityEngine;

namespace AnlautJam.Game.Trigger
{
    [RequireComponent(typeof(Collider))]
    public class TriggerView : MonoBehaviour, ITriggerView
    {
        private void OnTriggerEnter(Collider other)
        {
            OnTriggerEnterEvent?.Invoke(other);
        }

        public event Action<Collider> OnTriggerEnterEvent;
    }
}