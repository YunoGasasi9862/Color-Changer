using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform player;
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position.y < player.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);  //camera follow
        }
    }
}
