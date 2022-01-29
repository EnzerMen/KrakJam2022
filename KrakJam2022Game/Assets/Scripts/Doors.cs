using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Doors : Collidable
{
    public string sceneName;
    public int requiredItemID;
    [SerializeField] private string collectedByWho = "Player";
    //doors
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.CompareTag(collectedByWho))
        {
            //tp player
           

            if (GameManager.instance.hasAnItem[requiredItemID])
            {
                GameManager.instance.usedDoorID = requiredItemID;
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
            }
        }
    }




}
