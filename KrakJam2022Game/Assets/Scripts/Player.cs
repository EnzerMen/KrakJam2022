using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Animator animator;
    public float movementSpeed = 3;

    private Rigidbody2D rigidbodyComponent;
    private float horizontalInput;
     
    

    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody2D>();
        
    }
 
    void Update()
    {
        //zbieranie inputów do poruszania siê
        horizontalInput = Input.GetAxis("Horizontal");


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
    }

}
