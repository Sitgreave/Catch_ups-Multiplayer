using BH_InputHandler;
using UnityEngine;

namespace BH_Player.InputHandle
{
    public class MovementInput
    {
        public Vector3 KeyboardInput { get; private set; }
        private MouseInput a;
        
        
        private void HandleKeyboardInput()
        {
            
            KeyboardInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            // SummaryDirection = (CameraDirection * _keyboardInput).normalized;
        }
    }
}