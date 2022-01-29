using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopUpItemManager : MonoBehaviour
{
    public Image img;
    public TextMeshProUGUI txt;
    public GameObject container;

    public void Show(string msg, int fontSize, Color color, Image image)
    {
        
        img = image;
        txt.text = msg;
        txt.fontSize = fontSize;
        txt.color = color;
        container.SetActive(true);
    }

    public void Hide()
    {
        container.SetActive(false);
    }

    /* public GameObject textContainer;
    public GameObject textPrefab;

    private List<PopUpItem> PopUps = new List<PopUpItem>();
    
    // Start is called before the first frame update
    void Update()
    {
        foreach(PopUpItem popUp in PopUps)
        {
            popUp.UpdatePopUpItem();
        }
    }

    public void Show(string msg, int fontSize, Color color,Image image)
    {
        PopUpItem item = GetPopUp();

        item.txt.text = msg;
        item.txt.fontSize = fontSize;
        item.txt.color = color;
        item.image = image;
        item.go.transform.position = Camera.main.WorldToScreenPoint(Vector3.zero);

        item.Show();
    }






    private PopUpItem GetPopUp()
    {
        PopUpItem item = PopUps.Find(t => !t.active);

        if(item == null)
        {
            item = new PopUpItem();
            item.go = Instantiate(textPrefab);
            item.go.transform.SetParent(textContainer.transform);
            item.txt = item.go.GetComponent<TextMeshProUGUI>();
            item.image = item.go.GetComponent<Image>();

            PopUps.Add(item);
        }
        return item;
    }*/
}
