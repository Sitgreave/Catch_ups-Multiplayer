using System;
using AbstractSingleton;
using UnityEngine;

namespace Switcher
{
    public class CursorSwitcher: Singleton<CursorSwitcher>, ISwitcher
    {
        public void TurnOn()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        public void TurnOff()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}