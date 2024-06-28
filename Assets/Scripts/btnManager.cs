using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnManager : MonoBehaviour
{
    // startup enter button
    public void buttonEnter()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Back to start page (Kitchen)
    public void buttonBack()
    {
        SceneManager.LoadScene("StartScene");
    }
}
