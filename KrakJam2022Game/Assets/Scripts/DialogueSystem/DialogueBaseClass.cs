using System.Collections;
using UnityEngine;
using UnityEngine.UI;


namespace DialogueSystem
{
    public class DialgueBaseClass : MonoBehaviour

    {
        public bool finished { get; private set; }
        protected IEnumerator WriteText(string input, Text textHolder, float delayBetweenLines)
        {
            for (int i = 0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                yield return new WaitForSeconds(0.01f);
            }

            //yield return new WaitForSeconds(delayBetweenLines);
            yield return new WaitUntil(() => Input.GetButtonDown("Interact"));
            finished = true;
        }

    }

}
