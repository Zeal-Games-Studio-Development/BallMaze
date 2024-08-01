using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;

    private float XAxit;
    private float YAxit;
    [SerializeField] private Vector3 offset;


    private void FixedUpdate()
    {
        //YAxit += Input.GetAxis("Mouse X");
        //XAxit -= Input.GetAxis("Mouse Y");
        transform.position = target.transform.position + offset;
        transform.LookAt(transform.position);
    }



}
