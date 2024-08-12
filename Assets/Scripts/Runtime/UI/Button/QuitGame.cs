using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : BaseButton
{
    protected override void OnClick()
    {
        Application.Quit();
        Debug.Log("QUIT GAME");
    }
}
