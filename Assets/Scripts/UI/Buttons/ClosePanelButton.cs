using UI;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ClosePanelButton: PanelButton 
{
    [SerializeField] private UIPanel _panel;
    protected override void ButtonAction()
   {
      _panel.Close();
   }


}
