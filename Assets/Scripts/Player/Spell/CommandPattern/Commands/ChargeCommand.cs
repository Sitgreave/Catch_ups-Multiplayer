using Command;

namespace Player.Spell.Commands
{
    public class ChargeSpell: ISpell
    {
        public void Cast(SpellCaster caster)
        {
            caster.Charge();
        }
    }
}