using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMe : MonoBehaviour
{
    public Camera arCamera;

    void Start()
    {
        arCamera = Camera.main;
    }

    void Update()
    {
        if (arCamera != null)
        {
            // Make the UI look at the camera
            transform.LookAt(arCamera.transform);
            // Optionally, flip the UI so it is not backwards
            transform.Rotate(0, 180, 0);
        }
    }
}
