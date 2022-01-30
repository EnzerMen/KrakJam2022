using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Animator animReference;
    public GameObject MenuContainer;
    public void EndedAnimation()
    {
        Debug.Log("ENDED");
        animReference.SetBool("Started", true);
        MenuContainer.SetActive(true);


    }

    public void ExitLevel()
    {
        Application.Quit();
    }

    public void Credits()
    {
        animReference.SetTrigger("Credits");

    }

    public void ComeToMenu()
    {
        animReference.SetTrigger("comeBack");

    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Hub");

    }
}
