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
            target = mainCamera.transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
            if (Input.GetButtonUp("Fire1")) { grow = false; }

            if (grow == true)
            {
                transform.position = target;
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
