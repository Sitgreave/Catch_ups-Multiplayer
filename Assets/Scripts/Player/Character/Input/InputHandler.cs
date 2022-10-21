
using Player.Character.InputHandle.Switcher;
using UnityEngine;
using UnityEngine.Events;

namespace Player.Character.InputHandle
{
    public class InputHandler: MonoBehaviour
    {
        [SerializeField] private InputSwitcher _inputSwitcher;
        public Vector3 KeyboardInput { get; private set; }
        public UnityAction MouseDown1;
        public UnityAction MouseDown2;

        public static InputHandler Instance;

        private void Start()
        {
            if (Instance != null) Destroy(this);
            else Instance = this;
        }

        private void Update()
        {
            Debug.Log(KeyboardInput);
            if (_inputSwitcher.KeyboardInputEnable) HandleKeyboardInput();
            if (_inputSwitcher.MouseInputEnable) HandleMouseInput();
        }
        
        private void HandleMouseInput()
        {
            if (Input.GetMouseButtonDown(0)) MouseDown1?.Invoke();
            if (Input.GetMouseButtonDown(1)) MouseDown2?.Invoke();
        }

        private void HandleKeyboardInput()
        {
            KeyboardInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        }
      


      
    }
}