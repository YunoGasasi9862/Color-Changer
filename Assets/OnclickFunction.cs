using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class OnclickFunction : MonoBehaviour
{
    private Button inbounds;
    private void Start()
    {
        inbounds = GetComponentInParent<Button>();
    }


  
    public void Click()
    {

        inbounds.onClick.AddListener(OnClickRestart); //adds the listener on the mouse click on theb utton
        //takes in fucntion
    }

    public void OnClickRestart()
    {
       
       
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1) ;

        

    }
}