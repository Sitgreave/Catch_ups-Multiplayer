
using UnityEngine;

namespace BH_Camera
{
    public class CameraTracker: MonoBehaviour
    {
       
        [SerializeField] private float _distanceFromTarget;
        private Transform _trackTarget;
        private Transform _transform;
        
        private void Start()
        {
            if (Camera.main != null) _transform = Camera.main.transform;
        }
        

        public void TargetCatchUp()
        {
            if (_trackTarget == null) return; 
            _transform.position = _trackTarget.position - _transform.forward * _distanceFromTarget;
        }

        public void SetTarget(Transform target)
        {
            _trackTarget = target;
        }
       
    }
}