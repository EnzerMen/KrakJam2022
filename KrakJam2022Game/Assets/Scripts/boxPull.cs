using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxPull : MonoBehaviour
{
    public bool beingPushed;
    float xPos;
    void Start()
    {
        xPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (!beingPushed)
        {
            transform.position = new Vector3(xPos, transform.position.y);
        }
        else
        {
            xPos = transform.position.x;
        }
    }
}
