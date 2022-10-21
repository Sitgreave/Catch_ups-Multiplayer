using UnityEngine;

namespace UI
{
    public class PanelManager: MonoBehaviour
    {
        public void OpenPanel(UIPanel panel)
        {
            panel.gameObject.SetActive(true);
            panel.OnOpen();
        }
    }
}