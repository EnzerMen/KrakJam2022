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

        AnimationUpdate();
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

        if (moveButton != 0)
        {
            if (canJump)
                rigidBody.AddForce(new Vector2(moveButton * movementForce, 0), ForceMode2D.Impulse);
            else
            {
                rigidBody.AddForce(new Vector2(moveButton * movementForce * airMovementForce, 0), ForceMode2D.Impulse);
            }
            rigidBody.velocity = new Vector3(Mathf.Clamp(rigidBody.velocity.x, -5, 5), rigidBody.velocity.y, 0);
        }else
        {
            if (canJump)
                rigidBody.AddForce(new Vector2(-rigidBody.velocity.x*slowPower, 0), ForceMode2D.Impulse);
            else
            {
                rigidBody.AddForce(new Vector2(-rigidBody.velocity.x * slowPower *airMovementForce, 0), ForceMode2D.Impulse);
            }
        }

            
        
    }

    protected void Jump()
    {
        if (jumpButton != 0 && canJump)
        {
            rigidBody.AddForce(new Vector2(0, jumpButton * jumpForce), ForceMode2D.Impulse);
            canJump = false;
        }
    }


}
