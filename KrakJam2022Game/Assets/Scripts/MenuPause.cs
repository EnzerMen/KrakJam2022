using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuPause : MonoBehaviour
{
    public Animator anim;
    private bool doneOnce;

    

    public void Update()
    {

        if (Input.GetAxisRaw("Pause") == 1)
        {
            if (!doneOnce)
            {
                anim.SetTrigger("showPause");
                doneOnce = true;

            }
        }else if(doneOnce == true)
        {
            doneOnce = false;
        }        
            
         
        
    }

    public void onContinue()
    {
        //wylacz time diliation
    }


    public void onMenu()
    {
        //wczytaj mape menu
    }
    
}
