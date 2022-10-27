using System.Collections.Generic;

namespace BH_Player.Spell
{
    public class SpellCacher
    {
        private readonly Dictionary<Spell, Spell> _cachedSpell = new Dictionary<Spell, Spell>();

        public bool HasCached(Spell spell)
        {
            return _cachedSpell.ContainsKey(spell);
        }

        public Spell Get(Spell spell)
        {
            return _cachedSpell[spell];
        }

        public void Cache(Spell spell)
        {
            _cachedSpell.Add(spell, spell);
        }
    }
}