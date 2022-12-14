using UnityEngine;

namespace BH_Camera
{
    public class CameraController: MonoBehaviour
    {
        [SerializeField] private CameraRotator _cameraRotator;
        [SerializeField] private CameraTracker _cameraTracker;
        
        private void LateUpdate()
        {
            _cameraTracker.TargetCatchUp();
            _cameraRotator.Rotating();
        }
    }
}