using System.Collections;
using System.Threading.Tasks;
using BH_Player.Attributes;
using UnityEngine;
using UnityEngine.Events;

namespace BH_Player.Spell
{
    public abstract class Spell
    {
        public UnityAction OnCastStarted;
        public UnityAction OnCastEnded;
        protected Spell(SpellAttribute attribute)
        {
            Attribute = attribute;
        }
        protected SpellAttribute Attribute;

        public IEnumerator Cast()
        {
            OnCastStarted?.Invoke();
            yield return SpellRealization();
            OnCastEnded?.Invoke();

        }
        protected abstract IEnumerator SpellRealization();
    }
}