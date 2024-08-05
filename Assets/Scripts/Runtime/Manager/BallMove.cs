using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEditor.Rendering;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.Experimental.GlobalIllumination;
using ZealMVC.Runtime.Manager;

public class BallMove : MonoBehaviour
{
    public static BallMove Instance;
    public Rigidbody rb;

    [SerializeField] private ForceMode forceMode;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float powerJump;
    [SerializeField] private IntValue _score;
    [SerializeField] private bool isGrounded;
    [SerializeField] private float rayDistance;
    public Vector3 startPosision;

    private bool isInput;
    private Vector3 oldCheckPoint;
    


    private void Awake()
    {
        Instance = this;
        oldCheckPoint = transform.position;
        isInput = false;
        
    }
    private void Start()
    {
        _score = DataContainer.Instance.Score;
        _score.AddListener(OnScoreChanged);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isInput = true;
        }

    }

    private void FixedUpdate()
    {
        Move();
        OnGroud();     
        Jump(isInput);
        OnDrop();
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


        rb.AddForce(inputDirection * moveSpeed);
    }

    public void Jump( bool getInput)
    {
        if (isGrounded && isInput)
        {
            rb.AddForce(Vector3.up * powerJump, forceMode);
            isGrounded = false;
            isInput = false;
        }
    }
    public void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * powerJump, forceMode);
            isGrounded = false;
        }
    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Barrier")
        {

            ReturnCheckPoint();
        }
        else if(other.gameObject.tag == "CheckPoint")
        {
            Debug.Log("NEW CHECK POINT: " + transform.position);
            UpdateCheckPoint(transform.position);
            
        }
        else
        {
            _score.Value ++;
            Debug.Log("GET SCORE: " + _score.Value);
        }

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
        transform.position = oldCheckPoint;

        rb.velocity = Vector3.zero;

    }

    private void OnDrop()
    {
        if (transform.position.y <= -5)
        {
            ReturnCheckPoint();
        }
    }


    public void UpdateCheckPoint(Vector3 currentPoint)
    {
        if( Vector3.Distance(oldCheckPoint, currentPoint) >= 1)
        {
            oldCheckPoint = currentPoint;
        }
    }

    public void OnScoreChanged(int score)
    {
        Debug.Log(score.ToString());  
    }

    private void OnDestroy()
    {
        _score.RemoveListener(OnScoreChanged);
    }
}
