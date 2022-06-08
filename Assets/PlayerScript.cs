using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public string color;
    public Color Yellow;
    public Color Blue;
    public Color Purple;
    public Color Pink;
    public float speed;
    private GameManager gameManager;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
     }

    private void Start()
    {
        ColorChanger();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * speed;

            rb.bodyType = RigidbodyType2D.Dynamic;  //this is the change


        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(speed<=8)
            {

                speed += 1;
            }
         
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(speed>5)
            {
                speed -= 1;
            }

           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != color && collision.tag != "ColorChanger")
        {
            gameManager.GameOver();
            speed = 5;
        }


        if(collision.tag== "ColorChanger")
        {
            ColorChanger();
            Destroy(GameObject.FindWithTag("ColorChanger"));  //destroys
        }
    }

    


    void ColorChanger()
    {

        int Count = Random.Range(0, 3);
        switch(Count)
        {
            case 0:
                sr.color = Yellow;
                color = "Yellow";
                break;
            case 1:
                sr.color = Blue;
                color = "Blue";
                break;
            case 2:
                sr.color = Pink;
                color = "Pink";
                break;
            case 3:
                sr.color = Purple;
                color = "Purple";
                break;

        }
    }
}
