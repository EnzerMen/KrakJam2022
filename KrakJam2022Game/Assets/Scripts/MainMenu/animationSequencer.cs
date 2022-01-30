using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationSequencer : MonoBehaviour
{
    public Animator animSequence;
    public GameObject animContainer;
    public GameObject mainMenuReference;

    // Start is called before the first frame update
    void Start()
    {
        animSequence.SetBool("play_RGB", true);
    }

    public void killaAnimations()
    {
        mainMenuReference.GetComponent<MainMenu>().EndedAnimation();
        animContainer.SetActive(false);
    }
}
