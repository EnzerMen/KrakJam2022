using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Mover
{
    //input float
    private float moveButton;
    private float jumpButton;
    private string JUMPY_TAG = "JUMPY";
    private bool canJump = true;


    protected void FixedUpdate()
    {
        moveButton = Input.GetAxisRaw("Horizontal");
        jumpButton = Input.GetAxisRaw("Jump");

        Movement();
        Jump();

        //AnimationUpdate(new Vector3(0, 0, 0));
    }

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(JUMPY_TAG))
        {
            canJump = true;
        }
    }


    protected void Movement()
    {
        
        rigidBody.velocity = new Vector3(moveButton * movementSpeed, rigidBody.velocity.y, 0);
        
        
    }

    protected void Jump()
    {
        if (jumpButton != 0 && canJump)
        {
            Debug.Log("JUMP");
            rigidBody.AddForce(new Vector2(0, jumpButton * jumpForce), ForceMode2D.Impulse);
            canJump = false;
        }
    }


}
