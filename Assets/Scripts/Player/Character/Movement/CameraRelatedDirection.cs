
using BH_Player.InputHandle;
using Mirror;
using UnityEngine;

namespace BH_Player.Moving
{
    public readonly struct CameraRelatedDirection
    {
        public CameraRelatedDirection(Camera camera ) : this()
        {
            _cameraTransform = camera.transform;
        }
        
        private readonly Transform _cameraTransform;

        public Quaternion Get()
        {
            Quaternion cameraRelatedRotation = Quaternion.Euler(0, _cameraTransform.eulerAngles.y, 0);
            return cameraRelatedRotation;
        }
        
    }
}