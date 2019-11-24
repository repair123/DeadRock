using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    [SerializeField] StageManager SM;

    private  void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            SM.ShowClearUI();
        }
    }
}
