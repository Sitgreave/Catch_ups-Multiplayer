using BH_Player.Moving;
using UnityEngine;
using Motion = BH_Player.Moving.Motion;

namespace Player.Character.Movement
{
    public class Movement
    {
        public Movement(MoveAttribute moveAttribute, CharacterController characterController)
        {
            MoveAttribute moveAttribute1 = moveAttribute;

            _motion = new Motion(characterController, moveAttribute1.MoveSpeed);
            _rotating = new Rotating(characterController.transform, moveAttribute1.RotateSpeed);
        }
        
        private readonly Motion _motion;
        private readonly Rotating _rotating;
        private Vector3 _direction;

        public void Move(Vector3 direction)
        {
            _direction = direction;
            Moving();
            if (_direction == Vector3.zero) return;     
            Rotating();
        }
        
        private void Moving()
        {
            _motion.MoveTo(_direction);
        }

        private void Rotating()
        {
            _rotating.Rotate(_direction);
        }
        
    }
}