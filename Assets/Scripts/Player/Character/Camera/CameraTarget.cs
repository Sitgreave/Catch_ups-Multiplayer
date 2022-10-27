
using UnityEngine;

namespace BH_Camera
{
    public class CameraTarget : MonoBehaviour
    {

        private CameraTracker _cameraTracker;

        private void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            if (Camera.main == null) return;

            _cameraTracker = Camera.main.GetComponent<CameraTracker>();
            _cameraTracker.SetTarget(transform);
        }
    }
}