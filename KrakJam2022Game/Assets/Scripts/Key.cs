using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Collectable
{
    public int keyID;


    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GameManager.instance.hasAKey[keyID] = true;
            Destroy(gameObject);
            

            //GameManager.instance.ShowText("+" + pesosAmout + " pesos!", 25, Color.yellow, transform.position, Vector3.up * 50, 1.0f);
        }

        /*base.OnCollect();
        Debug.Log("Grant pesos");*/
    }

}
