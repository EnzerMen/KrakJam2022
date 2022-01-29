using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Doors : Collidable
{
    public int requiredItemID;
    [SerializeField] private string collectedByTag = "Player";
    [SerializeField] private GameObject teleportTo;
    [SerializeField] private GameObject playerObject;
    //doors
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.CompareTag(collectedByTag))
        {
            if (Input.GetAxisRaw("Interact") == 1)
            {
                if (GameManager.instance.hasAnItem[requiredItemID])
                {
                    playerObject.transform.position = teleportTo.transform.position;
                }
                else
                {
                    Debug.Log("nie ma klucza");
                }
            }
            
        }
    }

}
