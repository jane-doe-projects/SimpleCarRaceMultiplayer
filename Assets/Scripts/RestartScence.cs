using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScence : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Prototype 1");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            Restart();
        }

        if (Input.GetKeyDown("escape") == true)
        {
            Application.Quit();
        }
    }
}
