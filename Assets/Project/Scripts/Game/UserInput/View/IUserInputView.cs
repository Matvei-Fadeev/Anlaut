using System;
using UnityEngine;

namespace AnlautJam.Game.UserInput
{
    public interface IUserInputView
    {
        event Action<Vector3> OnUserAxis;
    }
}