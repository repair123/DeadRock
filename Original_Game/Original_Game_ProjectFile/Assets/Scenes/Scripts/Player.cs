using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float jumpHeight;
    public float speed;
    private float whichWay;
    public float feetRange;
    public Transform whereIsFeet;
    public LayerMask groundIs;
    private bool touchingGround;

    private bool lookingRight = true;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        whichWay = Input.GetAxisRaw("Horizontal");
        rigid.velocity = new Vector2(whichWay * speed, rigid.velocity.y);
        touchingGround = Physics2D.OverlapCircle(whereIsFeet.position, feetRange, groundIs);

        if(lookingRight == false && whichWay > 0)
        {
            Turn();
        }
        else if(lookingRight == true && whichWay < 0)
        {
            Turn();
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(touchingGround == true)
            {
                rigid.velocity = Vector2.up *  jumpHeight;
            }
        }
    }

    void Turn()
    {
        lookingRight = !lookingRight;
        Vector3 turner = transform.localScale;
        turner.x *= -1;
        transform.localScale = turner;
    }
}
