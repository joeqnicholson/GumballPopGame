using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.iOS;

public class SceneLoader : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        print('s');
    }
    private void Update()
    {
        if (Input.touchCount > 0)
            //if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
            print('s');
        }
    }
    
}
