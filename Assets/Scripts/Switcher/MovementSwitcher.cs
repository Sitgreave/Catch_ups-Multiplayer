using BH_Player.Moving;
using UnityEngine;

namespace Switcher
{
    public class MovementSwitcher: MonoBehaviour, ISwitcher
    {
        public bool MovingEnabled { get; private set; }

        public void TurnOn()
        {
            MovingEnabled = true;
        }

        public void TurnOff()
        {
            MovingEnabled = false;
        }
    }
}