using BH_Player.InputHandle;
using Player.Character.Movement;
using UnityEngine;

namespace BH_Player.Moving
{
    public class Motion
    {
        public Motion(CharacterController characterController, float moveSpeed)
        {
            _moveSpeed = moveSpeed;
            _characterController = characterController;
        }

        private readonly float _moveSpeed;
        private readonly CharacterController _characterController;
        
        public void MoveTo(Vector3 direction)
        { 
            _characterController.SimpleMove(direction * _moveSpeed);
        }
    }
}