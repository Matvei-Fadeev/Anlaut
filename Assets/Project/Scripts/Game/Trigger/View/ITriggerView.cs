using System;
using UnityEngine;

namespace AnlautJam.Game.Trigger
{
    public interface ITriggerView
    {
        IObservable<Collision> OnCollisionEnter { get; }
    }
}