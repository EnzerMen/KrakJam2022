using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField]private GameObject dialogue;
    private int blokada = 0;

    public void ActivateDialogue()
    {
        if (blokada == 0)
        {
            dialogue.SetActive(true);
            blokada++;
        }
       
    }

    public bool DialogueActive()
    {
        return dialogue.activeInHierarchy;
    }
}
