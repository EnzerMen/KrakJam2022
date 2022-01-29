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
    public bool standToDo = true;
    public bool canBack = false;
    


    public void Start()
    {
        startPos = transform.position;
        endPos = startPos + offset;

    }


    public void Update()
    {
        if (isMoving)
        {
            if (Mathf.Abs(transform.position.x - endPos.x) < 0.05f && Mathf.Abs(transform.position.y - endPos.y) < 0.05f)
            {
                transform.position = endPos;
            }

            transform.position = Vector3.Lerp(transform.position, endPos, forthSpeed * Time.deltaTime);
            if (standToDo)
            {
                isMoving = false;
            }
            else if (transform.position == endPos)
            {
                isMoving = false;
            }

        }
        else if(canBack)
        {
            transform.position = Vector3.Lerp(transform.position, startPos, backSpeed * Time.deltaTime);
        }
        
    }

    public void Move()
    {
        isMoving = true;

    }


}
