using UnityEngine;
using UnityEngine.Events;

namespace BH_InputHandler
{
    public class MouseInput
    {
        public UnityAction MouseDown1;
        public UnityAction MouseDown2;
        
        public void HandleMouseInput()
        {
            if (Input.GetMouseButtonDown(0)) MouseDown1?.Invoke();
            if (Input.GetMouseButtonDown(1)) MouseDown2?.Invoke();
        }

    }
}