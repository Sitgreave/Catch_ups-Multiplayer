using Switcher;
using UnityEngine;

namespace BH_Player.Spell
{
    public class SpellCaster : MonoBehaviour
    {
        [SerializeField] private MovementSwitcher _movementSwitcher;
        private Coroutine _castCoroutine;
        private readonly SpellCacher _spellCacher = new();
        public void CastSpell(Spell spell)
        {
            if (CasterNotReady()) return;
            TryCacheSpell(spell);
            StartCastRoutine(spell);
        }
        
        private bool CasterNotReady()
        {
            return _castCoroutine != null;
        }
        
        private void TryCacheSpell(Spell spell)
        {
            if (_spellCacher.HasCached(spell)) return;
            SetSpellActions(spell);
            _spellCacher.Cache(spell);
        }
        
        private void SetSpellActions(Spell spell)
        {
            spell.OnCastStarted += _movementSwitcher.TurnOff;
            spell.OnCastEnded += (() =>
            {
                _movementSwitcher.TurnOn();
                _castCoroutine = null;
            });
        }
        
        private void StartCastRoutine(Spell spell)
        {
            Spell cachedSpell = _spellCacher.Get(spell);
            _castCoroutine = StartCoroutine(cachedSpell.Cast());
        }
    }
}