using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlueLock : MonoBehaviour
{
    public Rigidbody ballRigidbody;
    public Transform legTarget;
    public float kickThreshold = 1.0f; // Adjust based on sensitivity
    public float kickForce = 10.0f;
    private Vector3 previousPosition;

    void Start()
    {
        if (legTarget != null)
        {
            previousPosition = legTarget.position;
        }
    }

    void Update()
    {
        if (legTarget != null)
        {
            Vector3 currentPosition = legTarget.position;
            Vector3 movement = currentPosition - previousPosition;

            if (movement.magnitude > kickThreshold)
            {
                KickBall(movement);
            }

            previousPosition = currentPosition;
        }
    }

    void KickBall(Vector3 direction)
    {
        ballRigidbody.AddForce(direction.normalized * kickForce, ForceMode.Impulse);
    }
}
