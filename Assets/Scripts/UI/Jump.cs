using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Jump : BaseButton
{

    protected override void OnClick()
    {
        BallMove.Instance.Jump();
    }
}
