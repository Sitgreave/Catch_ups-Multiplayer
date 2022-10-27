using System;
using BH_Player.Spell;
using UnityEngine;

namespace BH_Player.Attributes
{
    [Serializable]
    public class SpellAttribute
    {
        [SerializeField] private ChargeAttribute _chargeAttribute;
        public ChargeAttribute ChargeAttribute => _chargeAttribute;
        
        //...other spells 
    }
}