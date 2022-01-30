using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : Collectable
{
    public int itemID;
    public string text = "PLACEHOLDER TEXT";
    public int fontSize = 36;
    public Color textColor = Color.black;
    public Image image;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GameManager.instance.hasAnItem[itemID] = true;
            Destroy(gameObject);
            GameManager.instance.ShowItem(text, fontSize, textColor, image); ;
            GameManager.instance.ToggleTime();
        }

    }
}

