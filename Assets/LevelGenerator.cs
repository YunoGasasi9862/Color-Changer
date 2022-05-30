using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject Rotator;
    float maxSpeed=500;
    float minSpeed=200;
    int maxNumberofRotators = 10;
    float Height=2;
 
    void Start() //at the very start of the level 
    {
        Vector2 position = transform.position;

        for(int i=0; i<maxNumberofRotators; i++)
        {

            float newSpeed = Random.Range(minSpeed, maxSpeed);
            Rotator.GetComponent<Rotator>().speed = newSpeed; //this sets the new speed for the rotator
            position.y = Height; //at every 15
            Instantiate(Rotator, position, Quaternion.identity);
            Height += 10; //increment

        }
    }

   
}
