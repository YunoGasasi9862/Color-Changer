using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ColorChangerGenerator : MonoBehaviour
{
    float maxheight = 10;
    public GameObject colorChanger;
    int numberofObjects;

    void GeneratorBalls()
    {
        if(SceneManager.GetActiveScene().name=="Level1")
        {

            numberofObjects = 9;
        }else if(SceneManager.GetActiveScene().name=="Level2")
        {


            numberofObjects = 14;
        }else if(SceneManager.GetActiveScene().name=="Level3")
        {

            numberofObjects = 19;
        }


    }
    void Start()
    {
        Vector2 position = transform.position;
        GeneratorBalls();
        for (int i=0; i < numberofObjects; i++)
        {
            position.y += maxheight;  //place them at equal heights
            Instantiate(colorChanger, position, Quaternion.identity);

        }
        
    }

  
}
