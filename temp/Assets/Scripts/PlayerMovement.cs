﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerControl controller;
    public float runSpeed = 40f;
    public Animator animator;

    private float horizontalMove = 0f;
    private bool jump = false;
    private bool crouch = false;

    void Update() {
        
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump")) {
            jump = true;
            animator.SetBool("isJumping", true);
        }
        if(Input.GetButtonDown("Crouch")) {
            crouch = true;
        }
        else if(Input.GetButtonUp("Crouch")) {
            crouch = false;
        }
    }

    public void OnLanding() {
        animator.SetBool("isJumping", false);
    }

    public void OnCrouching(bool inCrouching) {
        animator.SetBool("isCrouching", inCrouching);
    }

    private void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
