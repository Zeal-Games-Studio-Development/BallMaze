using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputManager : MonoBehaviour
{
    public Vector3 move;
    private Vector3 direction;

    private void OnMove()
    {
        direction = new Vector3(Joystick.Instance.Direction.x, 0, Joystick.Instance.Direction.y);
        //transform.position += direction * moveSpeed * Time.fixedDeltaTime;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        move = new Vector3(horizontalInput, 0, verticalInput) + direction;


        if (move.magnitude > 1)
        {
            move.Normalize();

        }
    }
}
