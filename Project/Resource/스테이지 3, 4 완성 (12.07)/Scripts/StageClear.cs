using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClear : MonoBehaviour
{ 
	public GameObject player;
    [SerializeField] GameManager gm;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("Main Camera").GetComponent<AudioSource>().Stop();
            FindObjectOfType<AudioManager>().Play("StageClear");
            GameObject.Find("Player").GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
			player.GetComponent<PlayerMovement>().enabled = false;
            animator.SetTrigger("StageClear");
            gm.ShowClearUI();
        }
    }
}
