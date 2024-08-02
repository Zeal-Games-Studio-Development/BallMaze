using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{

    public GameObject Level;
    private void OnCollisionEnter(Collision collision)
    {
        Level.SetActive(false);
        Debug.Log("FINISH" );
    }

}
