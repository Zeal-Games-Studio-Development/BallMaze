using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public static BallMove Instance;
    public Rigidbody rd;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float powerJump;
    [SerializeField] private int score;

    private void Awake()
    {
        Instance = this;
        LoadScore();
    }

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

    public void Jump()
    {
        rd.AddForce(Vector3.up * powerJump, ForceMode.Impulse);

    }


    private void OnTriggerEnter(Collider other)
    {
        score++;
        SaveScore();
        Debug.Log("GET SCORE: " + score);
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
