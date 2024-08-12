using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    private PlayerInputManager input;
    public CharacterController controller;
    [SerializeField] private float speed;
    public Animator animator;

    private void Start()
    {
        input = GetComponent<PlayerInputManager>();

    }

    private void Update()
    {
        OnMove();
        


    }

    private void OnMove()
    {
        animator.SetFloat("speed", input.move.magnitude);
        transform.rotation = Quaternion.LookRotation(input.move);
        controller.Move(speed * Time.deltaTime * input.move);
    }



}
