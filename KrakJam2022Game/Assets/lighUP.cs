using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighUP : Collectable
{
    public GameObject changeLight;
    public Color lightColor;
    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            changeLight.GetComponent<SpriteRenderer>().color = lightColor;

        }


    }
}
