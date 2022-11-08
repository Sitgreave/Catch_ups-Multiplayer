using UnityEngine;

namespace Player.Character.Movement
{
    public class Rotating
    {
        public Rotating(Transform transform, float rotateSpeed)
        {
            _transform = transform;
            _rotateSpeed = rotateSpeed;
        }

        private readonly Transform _transform;
        private readonly float _rotateSpeed;

        public void Rotate(Vector3 direction)
        {
            if (direction == Vector3.zero) return;
            Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
            _transform.rotation = Quaternion.Slerp(_transform.rotation, rotation, _rotateSpeed * Time.deltaTime);
        }
    }
}