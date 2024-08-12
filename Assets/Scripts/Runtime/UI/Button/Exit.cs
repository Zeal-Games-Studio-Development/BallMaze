using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : BaseButton
{
    public GameObject panelMenu;
    public GameObject panelUI;
    protected override void OnClick()
    {
        Debug.Log("Exit button clicked");
        panelUI.SetActive(true);
        panelMenu.SetActive(false);
        
    }
}
