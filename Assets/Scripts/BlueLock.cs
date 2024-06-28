using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlueLock : MonoBehaviour
{
    public Rigidbody ballRigidbody;
    public Transform legTarget;
    public float kickThreshold = 0.5f; // Adjust based on sensitivity
    public float kickForce = 10.0f;
    private Vector3 previousPosition;

    public Renderer ballRenderer;
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
                KickBall();
            }

            previousPosition = currentPosition;
        }
    }

    void KickBall()
    {
        ballRigidbody.AddForce(Vector3.up * kickForce, ForceMode.Impulse);
        ballRenderer.material.color = Color.blue;
        StartCoroutine(ChangeColorBack());
    }

    IEnumerator ChangeColorBack()
    {
        yield return new WaitForSeconds(2);
        ballRenderer.material.color = Color.white;
    }
}
