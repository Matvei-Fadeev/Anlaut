using System;
using UnityEngine;

namespace Jam.Game.UserInput
{
    public interface IUserInputView
    {
        event Action<Vector3> OnUserAxis;
    }
}