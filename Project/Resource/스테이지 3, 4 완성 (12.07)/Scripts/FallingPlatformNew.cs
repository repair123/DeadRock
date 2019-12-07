using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatformNew : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            DropPlatform();
            Destroy(gameObject, 1.5f);
        }
    }

    void DropPlatform()
    {
        rb.isKinematic = false;
    }
}
