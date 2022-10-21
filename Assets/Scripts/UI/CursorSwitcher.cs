using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class CursorSwitcher: MonoBehaviour
    {
        private void Start()
        {
           CursorOff();
        }

        public void CursorOn()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        
        public void CursorOff()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}