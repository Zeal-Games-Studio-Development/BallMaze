using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : BaseButton
{
    public GameObject panelMenu;
    public GameObject panelUI;

    protected override void OnClick()
    {
        panelMenu.SetActive(true);
        panelUI.SetActive(false);
    }

}
