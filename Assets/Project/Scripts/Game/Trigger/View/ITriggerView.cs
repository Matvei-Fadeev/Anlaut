using System;
using UnityEngine;

namespace AnlautJam.Game.Trigger
{
    public interface ITriggerView
    {
        IObservable<Collider> OnCollisionEnter { get; }
        IObservable<Collider> OnCollisionExit { get; }
    }
}