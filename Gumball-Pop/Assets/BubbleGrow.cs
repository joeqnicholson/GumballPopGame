using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleGrow : MonoBehaviour
{
    bool grow;
    float size;
    Vector3 target;
    Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        grow = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(Gumball.gameOver == false)
        {
            if(Input.touchCount > 0)
            {
                target = mainCamera.transform.GetComponent<Camera>().ScreenToWorldPoint(Input.GetTouch(0).position);
            }
            
            if (Input.GetTouch(0).phase == TouchPhase.Ended) { grow = false; }

            if (grow == true)
            {
                transform.position = new Vector3(target.x,target.y,0);
                size += Time.deltaTime * 3;
                if (transform.localScale.x < 2.5f)
                {
                    transform.localScale += new Vector3(2.5f, 2.5f, 2.5f) * Time.deltaTime;
                }

            }
        }
        if(Gumball.gameOver == true)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
