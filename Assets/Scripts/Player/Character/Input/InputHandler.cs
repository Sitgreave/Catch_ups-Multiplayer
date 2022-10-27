using System;
using AbstractSingleton;
using BH_Player.Moving;
using UnityEngine;
using UnityEngine.Events;


namespace BH_Player.InputHandle
{
    public class InputHandler: Singleton<InputHandler>
    {
        public Vector3 RelatedDirection { get; private set; }
        private Vector3 _keyboardInput;
        private CameraRelatedDirection _cameraRelatedDirection;
        public UnityAction MouseDown1;
        public UnityAction MouseDown2;

        private void Start()
        {
            _cameraRelatedDirection = new CameraRelatedDirection(Camera.main);
        }

        public void Update()
        {
             HandleKeyboardInput();
             HandleMouseInput();
            
        }

        private void HandleMouseInput()
        {
            if (Input.GetMouseButtonDown(0))  MouseDown1?.Invoke();
            if (Input.GetMouseButtonDown(1)) MouseDown2?.Invoke();
        }

        private void HandleKeyboardInput()
        {
            _keyboardInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            if (_keyboardInput != Vector3.zero)
                RelatedDirection = (_cameraRelatedDirection.Get() * _keyboardInput).normalized;
            else RelatedDirection = Vector3.zero;
        }

        
        public void ClearKeyboardVector()
        {
            _keyboardInput = Vector3.zero;
        }
        
    }
}