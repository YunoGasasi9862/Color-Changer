using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnclickFunction : MonoBehaviour
{
    private void Update()
    {
        OnClickRestart();
    }



    public void OnClickRestart()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1) ;

        }

    }
}