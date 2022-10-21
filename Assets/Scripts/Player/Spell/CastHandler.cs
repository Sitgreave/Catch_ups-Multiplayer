using System;
using Command;
using Player.Character;
using Player.Character.InputHandle;
using Player.Spell.Commands;
using UnityEngine;

namespace Player.Spell
{
    public class CastHandler: MonoBehaviour
    {
        [SerializeField] private SpellCaster _caster;
        private readonly ISpell _mainSpell = new ChargeSpell();

        private void Start()
        {
            InputHandler.Instance.MouseDown1 += CastMainSpell;
        }

        private void CastMainSpell()
        {
            _mainSpell.Cast(_caster);
        }
    }
}