using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    //int bubbleScore;
    int top;
    // Start is called before the first frame update
    void Start()
    {
        top = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && top == 0)
        {
     
            Gumball gumBall = collision.gameObject.GetComponent<Gumball>();
            gumBall.score++;
            top++;
            print("wearedoingitman");
        }
    }
}
