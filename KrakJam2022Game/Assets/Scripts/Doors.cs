using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Doors : Collidable
{
    public string sceneName;
    public int keyID;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            //tp player
            //GameManager.instance.SaveState();

            if (GameManager.instance.keyes[keyID] == 1)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
            }
        }
    }




}
