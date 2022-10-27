using BH_Player.InputHandle;
using UnityEngine;

namespace BH_Player.Spell
{
    [RequireComponent(typeof(SpellCaster))]
    public class SpellHandler: MonoBehaviour
    {
        private SpellCaster _caster;
        private Spell _mainSpell;
        
        private void Start()
        {
            _caster = GetComponent<SpellCaster>();
            InputHandler.Instance.MouseDown1 += CastMainSpell;
        }

        private void CastMainSpell()
        {
            _caster.CastSpell(_mainSpell);
        }

        private void SetMainSpell(Spell spell)
        {
            _mainSpell = spell;
        }
    }
}