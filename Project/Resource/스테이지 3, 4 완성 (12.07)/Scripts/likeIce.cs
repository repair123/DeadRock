using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class likeIce : MonoBehaviour
{
    public GameObject player;

    private void Awake() {
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("ice in");
        if(collision.tag == "Player")
        {
            collision.GetComponent<PlayerControl>().setm_MovementSmoothing(0.3f);
        }
         
    }

    private void OnTriggerExit2D(Collider2D collision) {
        Debug.Log("ice out");
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerControl>().setm_MovementSmoothing(0.05f);
        }
    }
}
