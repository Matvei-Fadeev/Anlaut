using System;
using UnityEngine;

namespace Jam.Game.UserInput
{
    public class UserInputView : MonoBehaviour, IUserInputView
    {
        public event Action<Vector3> OnUserAxis;

        private void Update()
        {
            var horizontalAxis = Input.GetAxis("Horizontal");
            var verticalAxis = Input.GetAxis("Vertical");
            if (horizontalAxis != 0 || verticalAxis != 0)
            {
                OnUserAxis?.Invoke(new Vector3(horizontalAxis, 0, verticalAxis));
            }
        }
    }
}