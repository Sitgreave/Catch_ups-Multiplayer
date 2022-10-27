
using Switcher;

namespace BH_UI
{
    public class MenuPanel: UIPanel
    {
        public override void OnOpen()
        {
            CursorSwitcher.Instance.TurnOn();
            InputSwitcher.Instance.TurnOff();
            
        }

        public override void Close()
        {
            gameObject.SetActive(false);
            CursorSwitcher.Instance.TurnOff();
            InputSwitcher.Instance.TurnOn();
        }
    }
}