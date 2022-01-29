using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Collidable
{
    [SerializeField] private string collectedByTag = "Player";
    [SerializeField] private Movable moveThis;
    [SerializeField] private bool isToggable;



    protected override void OnCollide(Collider2D coll)
    {
        if (coll.CompareTag(collectedByTag))
        {
            if (isToggable)
            {
                if (Input.GetAxisRaw("Action") == 1)
                {
                    moveThis.Move();
                }
            }
            else
            {
                moveThis.Move();
            } 
        }
    }

}
