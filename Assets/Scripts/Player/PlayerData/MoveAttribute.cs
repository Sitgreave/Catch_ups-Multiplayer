using System;
using UnityEngine;

namespace BH_Player.Moving
{
    [Serializable]
    public struct MoveAttribute
    {
        [SerializeField] private float _moveSpeed;
        public float MoveSpeed => _moveSpeed;
        
        [SerializeField] private  float _rotateSpeed;
        public float RotateSpeed => _rotateSpeed;


    }
}