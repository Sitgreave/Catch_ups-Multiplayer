using System;
using BH_Player.Moving;
using BH_Player.Spell;
using UnityEngine;


namespace BH_Player.Attributes
{
    [CreateAssetMenu(fileName = "New Attribute Bundle", menuName = "Player Attributes Data", order = 10)]    
    public class PlayerAttributes: ScriptableObject
    {
        [SerializeField] private ChargeAttribute _chargeAttribute;
        public ChargeAttribute ChargeAttribute => _chargeAttribute;

        [SerializeField] private MoveAttribute _moveAttribute;
        public MoveAttribute MoveAttribute => _moveAttribute;
    }
}