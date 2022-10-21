using System;
using System.Collections;
using System.Collections.Generic;
using Player.Character.Movement;
using Player.Spell;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class Charge: MonoBehaviour
{
     [SerializeField][Range(1, 10)] private int _distance;
     [SerializeField] [Range(1, 100)] private int _speed;
     [SerializeField] private MovementSwitcher _movementSwitcher;
     private CharacterController _characterController;
     private Coroutine _chargeRoutine = null;
     private const int TimeDivideCoefficient = 2;
     private Transform _controllerTransform;

     private UnityAction _onChargeStarted;
     private UnityAction _onChargeEnded;
     
     private void Awake()
     {
         _characterController = GetComponent<CharacterController>();
         _controllerTransform = _characterController.transform;
         _onChargeEnded += OnChargeEnd;
         _onChargeStarted += OnChargeStart;

     }

     public void Cast()
     {
         _chargeRoutine ??= StartCoroutine(ChargeRoutine());
     }

     private IEnumerator ChargeRoutine()
    {
        float fixedTime = Time.fixedDeltaTime;
        float speed = _speed * fixedTime; 
        float time = _distance * fixedTime / speed;
        
        _onChargeStarted?.Invoke();
        while (time > 0)
        {
            _characterController.Move(_controllerTransform.forward * speed);
            time -= fixedTime;
            yield return new WaitForFixedUpdate();
        } 
        _onChargeEnded?.Invoke();
        _chargeRoutine = null;
    }

     private void OnChargeStart()
     {
         _movementSwitcher.DisableMove();
     }
     
     private void OnChargeEnd()
     {
         _movementSwitcher.EnableMove();
     }
    
    
 
}
