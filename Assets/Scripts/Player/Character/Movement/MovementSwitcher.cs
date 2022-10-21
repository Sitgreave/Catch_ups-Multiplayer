using UnityEngine;

namespace Player.Character.Movement
{
    public class MovementSwitcher: MonoBehaviour
    {
        [SerializeField] private CharacterMovement _characterMovement;
        [SerializeField] private CharacterRotator _characterRotator;

        public void DisableMove()
        {
            _characterMovement.enabled = false;
            _characterRotator.enabled = false;
        }
        
        public void EnableMove()
        {
            _characterMovement.enabled = true;
            _characterRotator.enabled = true;
        }
    }
}