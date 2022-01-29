using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
    //infos
    private Vector3 startPos, endPos;
    public Vector3 offset = new Vector3(0, 3f, 0);
    public float forthSpeed = 3;
    public float backSpeed = 0.2f;
    private bool isMoving = false;
    public bool canBack = false;
    private Vector3 normalizedVector3;

    private Rigidbody2D rb;
    


    public void Start()
    {
        startPos = transform.position;
        endPos = startPos + offset;
        rb = GetComponent<Rigidbody2D>();
        normalizedVector3 = Vector3.Normalize(endPos - startPos);

    }


    public void Update()
    {
        if (Mathf.Abs(transform.position.x - endPos.x) < 0.05f && Mathf.Abs(transform.position.y - endPos.y) < 0.05f)
        {
            isMoving = false;
            rb.velocity = Vector3.zero;
        }

        if (isMoving)
        {
            rb.velocity = normalizedVector3 * forthSpeed;

        }
        else if (canBack)
        {
            if (transform.position != startPos)
            {
                rb.velocity = -normalizedVector3 * backSpeed;
            }
            else if (Mathf.Abs(transform.position.x - startPos.x) < 0.05f && Mathf.Abs(transform.position.y - startPos.y) < 0.05f)
            {
                isMoving = false;
                rb.velocity = Vector3.zero;

            }

        }

        
    }

    public void Move()
    {
        isMoving = true;

    }


}
