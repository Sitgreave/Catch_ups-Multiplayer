using System;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

namespace Player.Character.Movement
{
    [RequireComponent(typeof(DirectionCalculator))]
    public class CharacterRotator: MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed;
        private DirectionCalculator _directionCalculator;
        private Vector3 _direction => _directionCalculator.Direction;
        private Transform _transform;
     
        private void Awake()
        {
            _directionCalculator = GetComponent<DirectionCalculator>();
            _transform = transform;
        }

        private void Update()
        {
            Rotating();
        }

        private void Rotating()
        {
            if (_direction == Vector3.zero) return;
            Quaternion rotation = Quaternion.LookRotation(_direction, Vector3.up);
            _transform.rotation =  Quaternion.Slerp(_transform.rotation, rotation, _rotationSpeed * Time.deltaTime);
        }
    }
}