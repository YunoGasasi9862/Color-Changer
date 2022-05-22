using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isOver=false;
   
    public  void GameOver()
    {
        while(!isOver)
        {
            Restart();
            isOver = true;
        }


    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);        

    }
}
