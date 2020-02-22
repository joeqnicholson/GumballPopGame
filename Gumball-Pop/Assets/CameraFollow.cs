using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Vector3 target;
    public Transform gumball;
    public GameObject bubble;
    bool grow;
    GameObject[] bubbles;
    // Start is called before the first frame update
    void Start()
    {
        bubbles = new GameObject[1];
    }
    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        if(Gumball.gameOver == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Destroy(bubbles[0]);

                GameObject tempHold;

                tempHold = Instantiate(bubble, target, transform.rotation);

                bubbles[0] = tempHold;


            }
            if (Input.GetButtonUp("Fire1"))
            {
                grow = false;
            }
            transform.position = Vector3.Lerp(transform.position, new Vector3(gumball.position.x, transform.position.y, transform.position.z), 0.5f);
        }

    }
    public void Grower(GameObject bubble)
    {
        if(grow == true)
        {
            
        }
    }
    
}
