using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLogic : MonoBehaviour
{
    public Transform gumball;
    public GameObject obstacle;
    public int distance;
    int lastSpawn;

    // Update is called once per frame
    void Update()
    {
        float gumPositionFloat = gumball.position.x;
        int gumPosX = (int)gumPositionFloat;

        if (gumPosX % 7 == 0 && lastSpawn < gumPosX)
        {
            lastSpawn = gumPosX;
            Instantiate(obstacle, new Vector3(gumPosX + distance, Random.Range(4.0f, 7.5f), 2), Quaternion.identity);
        }
    }
}
