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
    public Color pink;
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
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag!=color && collision.tag!="colorchanger")
        {
            gameManager.GameOver();
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
                sr.color = pink;
                color = "pink";
                break;
            case 3:
                sr.color = Purple;
                color = "Purple";
                break;

        }
    }
}
