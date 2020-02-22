using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        print('s');
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene(1);
            print('s');
        }
    }
    
}
