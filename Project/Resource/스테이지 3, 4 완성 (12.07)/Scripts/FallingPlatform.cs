using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
    }
}
