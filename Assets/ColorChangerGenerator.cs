using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerGenerator : MonoBehaviour
{
    float maxheight = 10;
    public GameObject colorChanger;
    int numberofObjects = 9;
    void Start()
    {
        Vector2 position = transform.position;
        for(int i=0; i < numberofObjects; i++)
        {
            position.y += maxheight;
            Instantiate(colorChanger, position, Quaternion.identity);

        }
        
    }

  
}
