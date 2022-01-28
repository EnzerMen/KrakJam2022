using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : Mover
{
    [SerializeField] private Transform groundCheck = null;
    float moveButton;
    float jumpButton;
    private bool canJump = true;
    private bool isGrounded;
    private string JUMP_TAG = "JUMPY";





    protected virtual void LateUpdate()
    {
        moveButton = Input.GetAxisRaw("Horizontal");
        jumpButton = Input.GetAxisRaw("Jump");

       
        Movement();
        AnimationUpdate(new Vector3(moveButton, rigidBody.velocity.y, 0));
      
    }
/*
  private override void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.CompareTag(JUMP_TAG))
        {
            isGrounded = true;

        }
    }
*/

    private void Movement()
    {
        //tmpJumpForce = jumpForce;
        rigidBody.velocity = new Vector3(moveButton * movementSpeed, rigidBody.velocity.y, 0);


        if (jumpButton == 1 && canJump)
        {

            rigidBody.AddForce(new Vector2(0, jumpButton*jumpForce), ForceMode2D.Impulse);
            //tmpJumpForce = 0;
            //canJump = false;
        }

    }

}
