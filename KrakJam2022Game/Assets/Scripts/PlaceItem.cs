using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItem : Collidable

{
    public int RequiredItemID;
    public string collectedByTag = "Player";
    private bool justClicked = false;
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject triggerForReflection;

    protected override void Start()
    {
        base.Start();
        triggerForReflection.SetActive(false);
    }

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.CompareTag(collectedByTag))
        {
/*            if (Input.GetButtonDown("Interact") && !justClicked)
            {
                justClicked = true;*/
                if (GameManager.instance.hasAnItem[RequiredItemID])
                {
                    triggerForReflection.SetActive(true);
                    GetComponent<BoxCollider2D>().enabled = false;
                }
            /* else
            {
                GameManager.instance.ShowText("i am missing something", 36, Color.white, playerObject.transform.position + new Vector3(0, 2, 0), new Vector3(0, 2, 0), 1.5f);
            }
       }
        else if (Input.GetButtonUp("Interact"))
        {
            justClicked = false;
        }*/
        }

    }
}
