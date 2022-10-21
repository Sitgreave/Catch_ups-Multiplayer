using System;
using UnityEngine;

namespace Player.Character.Movement
{
    [RequireComponent(typeof(CharacterController))]
    
    public class GravityComponent: MonoBehaviour
    {
        private CharacterController _characterController;
        private const float GravityScale = -9.81f;
        private Vector3 _playerVelocity;

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            UseGravity();
        }

        private void UseGravity()
        {
            if (_characterController.isGrounded && _playerVelocity.y < 0) _playerVelocity.y = 0; 
            _playerVelocity.y += GravityScale * Time.deltaTime;
            _characterController.Move(_playerVelocity * Time.deltaTime);
        }
    }
}