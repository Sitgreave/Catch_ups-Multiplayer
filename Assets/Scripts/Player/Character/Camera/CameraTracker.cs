
using UnityEngine;

namespace Player.Character.Camera
{
    public class CameraTracker: MonoBehaviour
    {
        [SerializeField] private Transform _trackTarget;
        [SerializeField] private float _distanceFromTarget;
        private Transform _transform;
        
        private void Awake()
        {
            _transform = transform;
        }
 

        public void TargetCatchUp()
        {
            _transform.position = _trackTarget.position - _transform.forward * _distanceFromTarget;
        }
       
    }
}