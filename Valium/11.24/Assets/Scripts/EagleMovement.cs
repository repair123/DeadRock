using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleMovement : MonoBehaviour
{
    public Transform eaglePos;
    private Transform initPos;
    public float moveTime = 10.5f;
    private float tempTime = 0f;
    private bool switchDir = false;

    private void Start() {
        tempTime = moveTime;
    }
    void FixedUpdate()
    {
        if(tempTime <= 0f)
        {
            tempTime = moveTime;
            switchDir = !switchDir;
        }
        else
        {
            tempTime -= Time.deltaTime;
        }

        if(switchDir)
        {
            eaglePos.position = new Vector2(eaglePos.position.x, eaglePos.position.y + 0.1f);
        }
        else
        {
            eaglePos.position = new Vector2(eaglePos.position.x, eaglePos.position.y - 0.1f);
        }
    }
}
