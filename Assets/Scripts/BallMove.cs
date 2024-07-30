using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class BallMove : MonoBehaviour
{

    public Vector3 moveDirection { get; private set; }
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

        Vector3 rollDirec = new Vector3(Joystick.Instance.Horizontal, 0, Joystick.Instance.Vertical);
        rd.AddForce(rollDirec * moveSpeed);
        
    }



}
