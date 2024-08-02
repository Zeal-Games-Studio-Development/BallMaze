using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostJump : MonoBehaviour
{
    public Rigidbody ball;
    [SerializeField] private float powerBoost;

    private void OnCollisionEnter(Collision collision)
    {
        ball.AddForce(Vector3.up * powerBoost, ForceMode.Impulse);
    }
}
