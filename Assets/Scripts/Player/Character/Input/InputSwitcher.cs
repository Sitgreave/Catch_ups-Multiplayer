
using UnityEngine;

namespace Player.Character.InputHandle.Switcher
{
    public class InputSwitcher: MonoBehaviour
    {
      
        public bool KeyboardInputEnable { get; private set; }
        public bool MouseInputEnable { get; private set; }
        
        private void Start()
        {
            EnableInput();
        }

        private void DisableKeyboardInput()
        {
            KeyboardInputEnable = false;
            
        }

        private void DisableMouseInput()
        {
            MouseInputEnable = false;
        }
        
        private void EnableKeyboardInput()
        {
            KeyboardInputEnable = true;
        }

        private void EnableMouseInput()
        {
            MouseInputEnable = true;
        }

        public void DisableInput()
        {
            DisableKeyboardInput();
            DisableMouseInput();
        }

        public void EnableInput()
        {
            EnableKeyboardInput();
            EnableMouseInput();
        }
    }
}