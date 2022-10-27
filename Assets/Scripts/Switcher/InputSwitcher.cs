
using AbstractSingleton;
using BH_Player.InputHandle;

namespace Switcher
{
    public class InputSwitcher: Singleton<InputSwitcher>, ISwitcher
    {
      
        public bool KeyboardInputEnable { get; private set; }
        public bool MouseInputEnable { get; private set; }

        private void DisableKeyboardInput()
        {
            KeyboardInputEnable = false;
          //  InputHandler.Instance.ClearKeyboardVector();
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

        public void TurnOn()
        {
            EnableKeyboardInput();
            EnableMouseInput();
        }

        public void TurnOff()
        {
            DisableKeyboardInput();
            DisableMouseInput();
        }
    }
}