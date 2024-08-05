using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : BaseButton
{
    public GameObject panel;
    protected override void OnClick()
    {
        panel.SetActive(false);
    }
}
