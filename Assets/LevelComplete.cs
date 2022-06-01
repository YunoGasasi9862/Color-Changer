using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    private GameManager gamemanager;

    private void Start()
    {
        gamemanager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            gamemanager.ChangeLevel();

        }
    }
}
