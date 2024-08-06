using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZealMVC.Runtime.Manager;

public class ChangeLevel : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        
        if (DataContainer.Instance.Level.Value < LevelManager.Instance.NumOfListLevel())
        {
            DataContainer.Instance.Level.Value++;
        }
        else
        {
            Debug.Log("MAX LEVEL");
        }
        
    }
}
