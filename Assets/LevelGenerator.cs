using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelGenerator : MonoBehaviour
{
    public GameObject Rotator;
    float maxSpeed=250;
    float minSpeed=-200;
    int maxNumberofRotators;
    float Height=2;

    void CheckLevel()
    {
        if(SceneManager.GetActiveScene().name=="Level1")
        {
            maxNumberofRotators = 10;

        }else if(SceneManager.GetActiveScene().name=="Level2")
        {

            maxNumberofRotators = 15;
        }else if(SceneManager.GetActiveScene().name=="Level3")
        {
            maxNumberofRotators = 20;
        }

    }
 
    void Start() //at the very start of the level 
    {
        Vector2 position = transform.position;
        CheckLevel();

        for(int i=0; i<maxNumberofRotators; i++)
        {

            //float newSpeed = Random.Range(minSpeed, maxSpeed);  //i assigned that new speed to rotator speed complonent :))
            //Rotator.GetComponent<Rotator>().speed = newSpeed; //this sets the new speed for the rotator
            //position.y = Height; //at every 15
            //Instantiate(Rotator, position, Quaternion.identity);
            //Height += 10; //increment

          float newspeed= Random.Range(minSpeed,maxSpeed);
            Rotator.GetComponent<Rotator>().speed = newspeed;
            position.y = Height;
            Instantiate(Rotator, position, Quaternion.identity);
            Height += 10;

        }
    }

   
}
