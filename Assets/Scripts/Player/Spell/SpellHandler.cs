using BH_Player.InputHandle;

namespace BH_Player.Spell
{
    public class SpellHandler
    {
        public SpellHandler(SpellCaster caster, Spell mainSpell)
        {
            _caster = caster;
            _mainSpell = mainSpell;
        }

        private SpellCaster _caster;
        private Spell _mainSpell;
        
        private void Start()
        {
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