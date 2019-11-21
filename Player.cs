using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   private Rigidbody2D rigid;
   public float jumpHeightl
   public float speed;
   private float whichWay;
   public float feetRange;
   public Transform whereIsFeet;
   publicLayerMask groundIs;
   private bool touchingGround;

   private boollookingRight = true;

   void Start()
   {
      rigid = GetComponent<Rigidbody2D>();
   }

   void FixedUpdate()
   {
      whicWay = Input.GetAxisRaw("Horizontal");
   rigid.velocity = new Vector2(whicWay * speed, rigid.veloctiy.y);
   touchingGround = Phtsics2D.OverlapCircle(whereIsFeet.position, feetRange,groundIs);

      if(lookingRight == false && whichWay > 0)
      {
          Turn();
      }
      else if(lookingRight == turn && whichWay < 0)
      {
        Trun();
      }

   }


   void Update()
   {
      if(Input.GetKeyDown(KeyCode.Space))
      {
         if(touchingGround == true)
         {
            rigid.velocity = Vector2.up * jumpHeight;
        }
      }
    }
    void Turn()
    {
      lookingRight =! lookingRight;
      Vector3 turner = transform.localScale;
      turner.x *= -1;
      transform.localScale = turner;
    }
  }
