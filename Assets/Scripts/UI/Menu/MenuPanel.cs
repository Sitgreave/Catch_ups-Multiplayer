using System;
using DefaultNamespace;
using Player.Character;
using Player.Character.InputHandle.Switcher;
using UnityEngine;

namespace Menu
{
    public class MenuPanel: UIPanel
    {
        [SerializeField] private CursorSwitcher _cursorSwitcher;
        [SerializeField] private InputSwitcher _inputSwitcher;
        public override void OnOpen()
        {
            _cursorSwitcher.CursorOn();
           _inputSwitcher.DisableInput();
            
        }

        public override void Close()
        {
            gameObject.SetActive(false);
            _cursorSwitcher.CursorOff();
            _inputSwitcher.EnableInput();
        }
    }
}