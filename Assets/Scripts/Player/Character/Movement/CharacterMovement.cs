
using Player.Character.Movement;
using UnityEngine;

[RequireComponent(typeof(CharacterController), typeof(DirectionCalculator))]
public class CharacterMovement : MonoBehaviour
{
   [SerializeField] private float _moveSpeed;
   [SerializeField] private DirectionCalculator _directionCalculator;
    private Vector3 _direction => _directionCalculator.Direction;
    
    private CharacterController _characterController;

   private void Awake()
   {
      _characterController = GetComponent<CharacterController>();
      _directionCalculator = GetComponent<DirectionCalculator>();
   }

   private void Update()
   {
       Movement();
   }

   private void Movement()
   {
      if (_direction == Vector3.zero) return;
     _characterController.Move(_direction * _moveSpeed * Time.deltaTime);
   }
  
   


}
