
using Player.Character.InputHandle;
using UnityEngine;

namespace Player.Character.Movement
{

    public class DirectionCalculator: MonoBehaviour
    {
        [SerializeField] private Transform _followedCameraTransform;
        public Vector3 Direction { get; private set; }

        private void Update()
        {
            Calculate();
        }

        private void Calculate()
        {
            Quaternion cameraRelatedRotation = GetCameraRelatedRotation();
            Vector3 movementInput = cameraRelatedRotation * InputHandler.Instance.KeyboardInput;
            Direction = movementInput.normalized;
           
        }

        private Quaternion GetCameraRelatedRotation()
        {
            return Quaternion.Euler(0, _followedCameraTransform.eulerAngles.y, 0);
        }
    }
}