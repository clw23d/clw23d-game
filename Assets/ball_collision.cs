using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_collision : MonoBehaviour
{
    // instantiate variables
    private Vector3 initialPosition;
    private Rigidbody rb;

    void Start()
    {
        //store the initial location of the sphere
        initialPosition = transform.position;
        // get the rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    // when object collides, reset the position to that saved var

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            //set the sphere's position to the initial position
            transform.position = initialPosition;
            //set velocity and angular velocity to zero
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

        }
        else if (collision.gameObject.name == "Goal")
        {
            Debug.Log("a winner is you!");
        }
        else
        {
            Debug.Log("nothing happened");
        }
    }
}
