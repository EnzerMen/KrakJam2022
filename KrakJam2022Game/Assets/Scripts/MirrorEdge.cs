using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorEdge : Collidable
{
    public bool isTeleporting = true;
    [SerializeField] private GameObject teleportLocation;
    [SerializeField] private GameObject reflectionReference;

    protected override void OnCollide(Collider2D coll)
    {
       if (coll.CompareTag("Reflection"))
        {
            if(isTeleporting)
                reflectionReference.transform.position = teleportLocation.transform.position;
        }
    }


}
