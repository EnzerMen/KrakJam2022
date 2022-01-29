using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField]private GameObject dialogue;

    public void ActivateDialogue()
    {
        dialogue.SetActive(true);
        Destroy(gameObject);
    }

    public bool DialogueActive()
    {
        return dialogue.activeInHierarchy;
    }
}
