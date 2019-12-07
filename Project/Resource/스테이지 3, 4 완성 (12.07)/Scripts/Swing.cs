using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public float degreesPerSecond = 10f;
    private float rotationDegreesPerSecond = 45f;
    public float rotationDegreesAmount = 90f;
    private float totalRotation = 0;
    private Vector3 dir;
    private bool isPlayerDead = false;

    // Use this for initialization
    void Start() {
        dir = new Vector3(0f, 0f, 1f);
    }

    // Update is called once per frame
    void FixedUpdate() {
        //if we haven't reached the desired rotation, swing
        if(!isPlayerDead)
        {
            if (Mathf.Abs(totalRotation) < Mathf.Abs(rotationDegreesAmount))
                SwingOpen();
            else
            {
                degreesPerSecond = -degreesPerSecond;
                SwingOpen();
            }
        }
        else
        {

        }

    }

    void SwingOpen() {
        
        float currentAngle = transform.rotation.eulerAngles.z;
        transform.rotation =
         Quaternion.AngleAxis(currentAngle + (Time.deltaTime * degreesPerSecond), dir);
        totalRotation += Time.deltaTime * degreesPerSecond;
        


    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("asfwefwef");
            isPlayerDead = true;
        }
    }
}
