using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Animator animator;
    [SerializeField] private float movementSpeed = 3;
    [SerializeField] private float jumpPower = 3f;
    [SerializeField] private Transform groundCheckTransform = null;

    private Rigidbody2D rigidbodyComponent;
    private float horizontalInput;
    private bool jumpKeyWasPressed;
     
    
    //oks
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody2D>();
        
    }
 
    void Update()
    {
        //zbieranie inputów do poruszania siê
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;

        }


        //animacje skoku

        if (rigidbodyComponent.velocity.y == 0)
        {
            animator.SetBool("IsJumping", false);
            animator.SetBool("isFalling", false);
        }

        if (rigidbodyComponent.velocity.y > 0)
        {
            animator.SetBool("IsJumping", true);
        }

        if (rigidbodyComponent.velocity.y < 0)
        {
            animator.SetBool("IsJumping", false);
            animator.SetBool("isFalling", true);
        }


    }

    private void FixedUpdate()
    {




        //poruszanie siê postaci

        rigidbodyComponent.velocity = new Vector2(horizontalInput * movementSpeed, rigidbodyComponent.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(horizontalInput));

        //Rotacja horyzontalna

        Vector3 characterScale = transform.localScale;
        if (horizontalInput < 0) { characterScale.x = Mathf.Abs(characterScale.x) * -1; }
        if (horizontalInput > 0) { characterScale.x = Mathf.Abs(characterScale.x); }
        transform.localScale = characterScale;

        //skok

        Debug.Log(Physics2D.OverlapCircleAll(groundCheckTransform.position, 0.1f).Length);

        if (Physics2D.OverlapCircleAll(groundCheckTransform.position, 0.1f).Length == 1) 
        {
         
            return;
        }

        if (jumpKeyWasPressed)
        {
            rigidbodyComponent.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jumpKeyWasPressed = false;
        }






    }

}
