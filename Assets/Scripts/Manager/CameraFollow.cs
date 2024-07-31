using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;

    private float XAxit;
    private float YAxit;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float rotationSpeed = 5f;
    public Joystick Joystick;

    private void FixedUpdate()
    {
        //YAxit += Input.GetAxis("Mouse X");
        //XAxit -= Input.GetAxis("Mouse Y");
        Vector3 dir = new Vector3(Joystick.Instance.Direction.x, 0, Joystick.Instance.Direction.y);
        transform.position = target.transform.position + offset + dir;

        transform.rotation = Quaternion.LookRotation(dir * Time.fixedDeltaTime);
        transform.LookAt(transform.position);
    }



}
