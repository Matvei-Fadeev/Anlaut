using System;
using UnityEngine;

namespace Jam.Game.Trigger
{
    public interface ITriggerView
    {
        IObservable<Collider> OnCollisionEnter { get; }
        IObservable<Collider> OnCollisionExit { get; }
    }
}