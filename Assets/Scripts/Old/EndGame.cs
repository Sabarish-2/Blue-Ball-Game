using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{

    public void OnTriggerEnter2d(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
                  
            SceneManager.LoadScene(1);
        }
    }
}