
using System.Collections;
using System.Threading.Tasks;
using BH_Player.Attributes;
using UnityEngine;


namespace BH_Player.Spell
{
    public class Charge: Spell
    {
        public Charge(SpellAttribute attribute, CharacterController characterController) : base(attribute)
        {
            SetSpeed();
            _characterController = characterController;
        }
        
        private readonly Transform _controllerTransform;
        private readonly CharacterController _characterController;
        private float _speed;
        private float _fixedTime;
        private float _chargeTime => Attribute.ChargeAttribute.Time;
        
       protected override IEnumerator SpellRealization ()
        {
            float timePassed = 0;
          
            while (timePassed < _chargeTime)
            {
                _characterController.Move(_controllerTransform.forward * _speed);
                timePassed += _fixedTime;
                yield return new WaitForFixedUpdate();
            }
        }
        
        private void SetSpeed()
        {
            float fixedTime = Time.fixedDeltaTime;
            float time = Attribute.ChargeAttribute.Time;
            float distance =  Attribute.ChargeAttribute.Distance * fixedTime;
            _speed = (distance / time);
        }

        
    }
}