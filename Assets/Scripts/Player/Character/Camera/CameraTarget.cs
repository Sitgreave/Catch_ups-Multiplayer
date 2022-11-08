using UnityEngine;

namespace BH_Camera
{
    public class CameraTarget : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        private CameraTracker _cameraTracker;

        public void Initialize(CameraTracker _cameraTracker)
        {
            _cameraTracker.SetTarget(_target);
        }
    }
}