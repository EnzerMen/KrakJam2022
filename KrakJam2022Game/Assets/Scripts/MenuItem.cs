using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuItem : MonoBehaviour
{
    public TextMeshProUGUI myName;
    public Image myImage;
    public string itemName = "wpisz opis przedmiotu";
    public int itemID;
    public Color grayTint = new Color(0.9f,0.9f,0.9f,0.5f);

    void LateUpdate()
    {
        if (GameManager.instance.hasAnItem[itemID])
        {
            myName.text = itemName;
            myImage.color = Color.white;
            
        }
        else
        {
            myImage.color = grayTint;
            myName.text = null;

        }

    }


}
