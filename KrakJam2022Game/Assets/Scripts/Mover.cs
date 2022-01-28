using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mover : MonoBehaviour
{
    #region variables
    //basics
    protected BoxCollider2D boxCollider;
    protected Rigidbody2D rigidBody;
    protected Vector3 moveDelta;
    protected SpriteRenderer spriteRend;

    [SerializeField]
    protected float movementSpeed = 6f;
    [SerializeField]
    protected float jumpForce = 2f;

    protected Vector3 baseScale;
    //animations
    protected Animator animator;
    #endregion


    

    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
        
        baseScale = transform.localScale;
    }


    protected virtual void AnimationUpdate(Vector3 input)
    {
        
        //reset move delta
        moveDelta = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, 0);

        #region swap sprite X direction and change anim bools
        if (moveDelta.x != 0)
        {

            if (moveDelta.x > 0)
                transform.localScale = new Vector3(baseScale.x, baseScale.y, baseScale.z);
            else if (moveDelta.x < 0)
                transform.localScale = new Vector3(-baseScale.x, baseScale.y, baseScale.z);

            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
        #endregion

        #region jump animation

        if (moveDelta.y == 0)
        {
            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", false);
        }
        if (moveDelta.y > 0)
        {
            animator.SetBool("isJumping", true);
            animator.SetBool("isFalling", false);
        }
        if (moveDelta.y < 0)
        {
            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", true);
        }

        #endregion

    }

}
