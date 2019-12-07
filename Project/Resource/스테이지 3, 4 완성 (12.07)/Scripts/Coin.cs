using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(other is BoxCollider2D)
            {
                FindObjectOfType<AudioManager>().Play("Coin");
                GameManager.instance.GetScore();
                Destroy(gameObject);
            }
            
        }
    }
}
