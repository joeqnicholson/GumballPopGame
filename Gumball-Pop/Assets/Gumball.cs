using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gumball : MonoBehaviour
{
    public static bool gameOver;
    public float launchSpeed;
    Rigidbody2D gumball;
    public GameObject tapToRestart;
    public int score;

    void Start()
    {
        //top = score;
        gumball = GetComponent<Rigidbody2D>();
        gameOver = false;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("Bubble"))
        {
            GameObject bubble = collision.gameObject;
            Transform bubbleTransform = bubble.transform;
            float bubbleScale = bubbleTransform.localScale.x;
        
            if (collision.contacts[0].normal.y < 0)
            {
                gumball.AddForce(collision.contacts[0].normal * 2, ForceMode2D.Impulse);
            }
            else
            {
                gumball.AddForce(collision.contacts[0].normal * (launchSpeed + bubbleScale), ForceMode2D.Impulse);
                gumball.AddForce(Vector2.up * (bubbleScale - .4f), ForceMode2D.Impulse);
            }
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gumball.AddForce(collision.contacts[0].normal, ForceMode2D.Impulse);
            print('h');
            gameOver = true;
            Instantiate(tapToRestart);
        }


        //if (collision.gameObject.CompareTag("Obstacle"))
        //{
            
        //}

    }
}
