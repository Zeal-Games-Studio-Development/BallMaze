using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    [SerializeField] private Vector3 offset;


    private void FixedUpdate()
    {

        transform.position = target.transform.position + offset;
        transform.LookAt(transform.position);
    }



}
