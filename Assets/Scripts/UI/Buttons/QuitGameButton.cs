using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;

public class QuitGameButton : PanelButton
{
    protected override void ButtonAction()
    {
       Application.Quit();
    }

 
}
