using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void Update()
    {
        // Use this for initialization
        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("Main");
        }
        if (Input.GetKeyDown("1"))

        {
            SceneManager.LoadScene("Stage1");
        }
        if (Input.GetKeyDown("2"))
        {
            SceneManager.LoadScene("Stage2");
        }
    }
}
