using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpeed : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private float speedBoost;

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity += Vector3.forward * speedBoost;
    }
}
