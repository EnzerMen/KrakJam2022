using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Collidable
{
    [SerializeField] private string collectedByTag = "Player";
    [SerializeField] private Movable moveThis;
    [SerializeField] private bool isToggable;
    [SerializeField] private bool hasToHaveAnItem;
    [SerializeField] private int requiredItemID;



    protected override void OnCollide(Collider2D coll)
    {
        if (coll.CompareTag(collectedByTag))
        {
            if (hasToHaveAnItem)
            {
                if (GameManager.instance.hasAnItem[requiredItemID] == true)
                {
                    DoTrigger();
                }
            }
            else
            {
                DoTrigger();
            }
            
            
            
            

        }
    }



    protected void DoTrigger()
    {
        if (isToggable)
        {
            if (Input.GetAxisRaw("Interact") == 1)
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
