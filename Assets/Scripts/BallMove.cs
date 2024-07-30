using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class BallMove : MonoBehaviour
{

    public Rigidbody rd;

    [SerializeField] private float moveSpeed;

    private void FixedUpdate()
    {
        Move();
        
    }

    private void Move()
    {
        //Vector3 direction = new Vector3(Joystick.Instance.Direction.x, 0, Joystick.Instance.Direction.y);
        //transform.position += direction * moveSpeed * Time.fixedDeltaTime;

        Vector3 rollDirection = new Vector3(Joystick.Instance.Direction.x, 0, Joystick.Instance.Direction.y);
        rd.AddForce(rollDirection * moveSpeed);

    }



}
