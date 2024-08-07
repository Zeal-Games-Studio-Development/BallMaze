using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : BaseButton
{
    public GameObject panel;
    protected override void OnClick()
    {
        panel.SetActive(true);
    }

}
