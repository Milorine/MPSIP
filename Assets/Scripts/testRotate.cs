using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testRotate : MonoBehaviour
{
    // Speed of rotation in degrees per second
    public float rotationSpeed = 90f;

    // Update is called once per frame
    void Update()
    {
        // Calculate the rotation for this frame
        float rotationAmount = rotationSpeed * Time.deltaTime;

        // Rotate the object around its Y-axis
        transform.Rotate(0, rotationAmount, 0);
    }
}
