using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : BaseButton
{
    public GameObject panelOpen;
    public GameObject panelClose;

    protected override void OnClick()
    {
        panelOpen.SetActive(true);
        panelClose.SetActive(false);
    }

}
