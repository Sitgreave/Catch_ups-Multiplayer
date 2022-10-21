
using Menu;
using UI;
using UnityEngine;

public class InputHandlerUI : MonoBehaviour
{
    [SerializeField] private PanelManager _panelManager;
    [SerializeField] private MenuPanel _menuPanel;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            if (MenuNotOpened())
            {
                _panelManager.OpenPanel(_menuPanel);
               
            }
            else _menuPanel.Close();
        };
    }

    private bool MenuNotOpened()
    {
        return !_menuPanel.gameObject.activeSelf;
    }
}
