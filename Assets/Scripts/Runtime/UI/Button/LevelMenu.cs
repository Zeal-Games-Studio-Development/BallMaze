using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZealMVC.Runtime.Manager;

public class LevelMenu : MonoBehaviour
{
    public GameObject openPanel;
    public void OpenLevel(int level)
    {
        DataContainer.Instance.Level.Value = level;
        gameObject.SetActive(false);
        openPanel.SetActive(true);
        BallMove.Instance.transform.position = BallMove.Instance.startPosision;
    }
}
