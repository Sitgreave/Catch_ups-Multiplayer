using BH_Player.InputHandle;
using Player.Character.Movement;
using UnityEngine;

namespace BH_Player.Moving
{
    public class Movement
    {
        public Movement(MoveAttribute attribute, CharacterController characterController, InputHandler inputHandler)
        {
            _attributes = attribute;
            _characterController = characterController;
            _transform = _characterController.transform;
            _inputHandler = inputHandler;
        }

        private readonly MoveAttribute _attributes;
        private Vector3 _direction => _inputHandler.RelatedDirection;
        private InputHandler _inputHandler;
        private Transform _transform;
        private CharacterController _characterController;

        public void OnUpdate()
        {
            if (!DirectionInputed()) return;
            
            Moving();
            Rotating();
        }
        
        private bool DirectionInputed()
        {
            return _direction != Vector3.zero;
        }
        
        private void Moving()
        {
            _characterController.Move(_direction * _attributes.MoveSpeed * Time.deltaTime);
        }

        private void Rotating()
        {
            Quaternion rotation = Quaternion.LookRotation(_direction, Vector3.up);
            Quaternion.Slerp(_transform.rotation, rotation, _attributes.RotateSpeed * Time.deltaTime);
        }

       

    }
}