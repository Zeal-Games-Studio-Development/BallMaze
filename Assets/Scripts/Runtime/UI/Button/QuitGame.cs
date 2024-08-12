using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZealMVC.Runtime.Manager;

public class QuitGame : BaseButton
{
    protected override void OnClick()
    {
        DataContainer.Instance.Score.Value = 0;
        Application.Quit();
        Debug.Log("QUIT GAME");
    }
}
