using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    private Transform lookAtPlayer;
    private Transform lookAtReflection;

    private void Start()
    {
        lookAtPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        lookAtReflection = GameObject.FindGameObjectWithTag("Reflection").transform;

    }
    void LateUpdate()
    {
        if (GameManager.instance.followPlayer)
        {
            transform.position = new Vector3(lookAtPlayer.transform.position.x, lookAtPlayer.transform.position.y, -1);
        }
        else if(!GameManager.instance.followPlayer)
        {
            transform.position = new Vector3(lookAtReflection.transform.position.x, lookAtReflection.transform.position.y, -1);
        }
    }


}

