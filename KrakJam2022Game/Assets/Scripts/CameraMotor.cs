using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    private Transform lookAt;


    private void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void LateUpdate()
    {
        
        transform.position = new Vector3(lookAt.transform.position.x, lookAt.transform.position.y, -1);

    }


}

