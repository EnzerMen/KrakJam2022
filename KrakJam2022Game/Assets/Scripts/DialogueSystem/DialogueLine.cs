using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace DialogueSystem
{
    public class DialogueLine : DialgueBaseClass
    {
        private Text textHolder;
        [Header ("Text Options")]
        [SerializeField]private string input;
        [SerializeField]private float delayBetweenLines;

        [Header ("Character Image")]
        [SerializeField] private Sprite characterSprite;
        [SerializeField] private Image imageHolder;




        private void Awake()
        {
            textHolder = GetComponent<Text>();
            textHolder.text = "";

            
            imageHolder.sprite = characterSprite;
            imageHolder.preserveAspect = true;
        }

        private void Start()
        {
            StartCoroutine(WriteText(input, textHolder, delayBetweenLines));
        }

    }
}