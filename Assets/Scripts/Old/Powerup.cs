using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public float M = 1.4f;
    public GameObject PU;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            Pickup(other);
    }
    void Pickup(Collider2D Player)
    {
        Instantiate( PU );
        Player.transform.localScale *= M;
        Destroy(gameObject);
    }
}
