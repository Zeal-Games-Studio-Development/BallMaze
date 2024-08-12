using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZealMVC.Runtime.Manager;

public class SetNextLevel : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        DataContainer.Instance.Level.Value ++;
    }
}
