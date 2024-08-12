using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZealMVC.Runtime.Manager;

public class LevelMenu : MonoBehaviour
{
    public void OpenLevel(int level)
    {
        DataContainer.Instance.Level.Value = level;
    }
}
