using System;
using UnityEngine;

namespace AnlautJam.Game.Trigger
{
    public interface ITriggerView
    {
        event Action<Collider> OnTriggerEnterEvent;
    }
}