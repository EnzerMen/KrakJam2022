using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Doors : Collidable
{
    public int requiredItemID;
    [SerializeField] private string collectedByTag = "Player";
    [SerializeField] private GameObject playerTeleportTo;
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject reflectionTeleportTo;
    [SerializeField] private GameObject reflectionObject;

    private bool justClicked = false;
    //doors
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.CompareTag(collectedByTag))
        {
            if (Input.GetAxisRaw("Interact") == 1 && !justClicked)
            {
                justClicked = true;
                if (GameManager.instance.hasAnItem[requiredItemID])
                {
                    playerObject.transform.position = playerTeleportTo.transform.position;
                    reflectionObject.transform.position = reflectionTeleportTo.transform.position;
                    reflectionObject.GetComponent<Reflection>().ToggleMoving(false);
                }
                else
                {
                    GameManager.instance.ShowText("these doors are locked", 36, Color.white, playerObject.transform.gameObject.transform.position+new Vector3(0,2,0), Vector3.zero, 2.0f);
                    Debug.Log("nie ma klucza");
                }
            }else if(Input.GetAxisRaw("Interact") == 0)
            {
                justClicked = false;
            }
            
        }
    }

}
