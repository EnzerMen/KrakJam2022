using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Doors : Collidable
{
    public string sceneName;
    public int keyID;
    [SerializeField] private string collectedByWho = "Player";
    //doors
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.CompareTag(collectedByWho))
        {
            //tp player
           

            if (GameManager.instance.hasAKey[keyID])
            {
                GameManager.instance.usedDoorID = keyID;
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
            }
        }
    }




}
