using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEditor.Rendering;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.Experimental.GlobalIllumination;

public class BallMove : MonoBehaviour
{
    public static BallMove Instance;
    public Rigidbody rd;

    [SerializeField] private ForceMode forceMode;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float powerJump;
    [SerializeField] private int score;
    [SerializeField] private bool isGrounded;
    [SerializeField] private float rayDistance;

    private Vector3 oldCheckPoint;

    private void Awake()
    {
        Instance = this;
        oldCheckPoint = transform.position;
        LoadScore();
    }

    private void FixedUpdate()
    {
        Move();
        OnGroud();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
        ReturnCheckPoint();
    }

    private void Move()
    {
        Vector3 direction = new Vector3(Joystick.Instance.Direction.x, 0, Joystick.Instance.Direction.y);
        //transform.position += direction * moveSpeed * Time.fixedDeltaTime;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 inputDirection = new Vector3(horizontalInput, 0, verticalInput) + direction;

  
        if (inputDirection.magnitude > 1)
        {
            inputDirection.Normalize();
        }


        rd.AddForce(inputDirection * moveSpeed);
    }

    public void Jump()
    {
        if (isGrounded)
        {
            rd.AddForce(Vector3.up * powerJump, forceMode);
            isGrounded = false; 
        }
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Barrier")
        {

            transform.position = oldCheckPoint;
        }
        else
        {
            score++;
            SaveScore();
            Debug.Log("GET SCORE: " + score);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }


    private void OnGroud()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, rayDistance))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    private void ReturnCheckPoint()
    {
        if(transform.position.y <= -5)
        {
            transform.position = oldCheckPoint;
            rd.AddForce(Vector3.zero);
        }
        
    }

    private void SaveScore()
    {
        PlayerPrefs.SetInt("PlayerScore", score); 
        PlayerPrefs.Save(); 
    }


    public void LoadScore()
    {
        if (PlayerPrefs.HasKey("PlayerScore"))
        {
            score = PlayerPrefs.GetInt("PlayerScore");
        }
        else
        {
            score = 0;
        }
    }
}
