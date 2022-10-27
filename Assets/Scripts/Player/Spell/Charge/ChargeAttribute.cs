using System;
using UnityEngine;

namespace BH_Player.Spell
{
    [Serializable]
    public struct ChargeAttribute
    {
        [SerializeField] private int _distance;
        public int Distance => _distance;
        [SerializeField] private float _time;
        public float Time => _time;
    }
}