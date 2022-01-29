using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable
{
    // Start is called before the first frame update
    //logic
    protected bool collected;
    [SerializeField] private string collectedByTag = "Player";

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.CompareTag(collectedByTag))
        {
            OnCollect();
        }
    }


    protected virtual void OnCollect()
    {
        collected = true;
    }

}
