using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    private Transform lookAtPlayer;
    private Transform lookAtReflection;
    private Vector3 newLookAt;
    private bool lerping;

    private void Start()
    {
        lookAtPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        lookAtReflection = GameObject.FindGameObjectWithTag("Reflection").transform;
        transform.position = new Vector3(lookAtPlayer.transform.position.x, lookAtPlayer.transform.position.y, -1);
    }
    void LateUpdate()
    {

        if (GameManager.instance.followPlayer)
        {
            newLookAt = new Vector3(lookAtPlayer.transform.position.x, lookAtPlayer.transform.position.y + 5, -1);
            transform.position = newLookAt;

        }
        else if(!GameManager.instance.followPlayer)
        {
            newLookAt = new Vector3(lookAtReflection.transform.position.x, lookAtReflection.transform.position.y + 4, -1);
            transform.position = newLookAt;
        }
    }

}

