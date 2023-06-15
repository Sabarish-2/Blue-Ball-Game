using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public int Coinvalue = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            ScoreManager.instance.ChangeScore(Coinvalue);
            StartCoroutine(P(other));

        }

        IEnumerator P(Collider2D Player)
        {
            yield return new WaitForSeconds(1f);
        }
        
    }
    //private void Update()
    //{
    //    if (Coinvalue >= 70)
    //    {
    //        SceneManager.LoadScene(3);
    //    }
    //}
}
