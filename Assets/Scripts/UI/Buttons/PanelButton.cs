using UnityEngine;
using UnityEngine.UI;


namespace UI
{
    [RequireComponent(typeof(Button))]
    public abstract class PanelButton: MonoBehaviour
    {
        protected Button Button;
        private void Start()
        {
            Button = GetComponent<Button>();
            Button.onClick.AddListener(ButtonAction);
        }

       protected abstract void ButtonAction();
    }
}