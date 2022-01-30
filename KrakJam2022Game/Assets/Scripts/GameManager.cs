using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;
    public Reflection reflection;
    public GameObject character;
    public GameObject cameraPref;
    public GameObject endPopUp;
    public FloatingTextManager floatingTextManager;
    public PopUpItemManager popUpItemManager;
    public bool canSwitch = false;
    private bool justSwitched = false;
    public bool followPlayer = true;


    public bool [] hasAnItem = new bool[20]; //lista przedmiotów mam/niemam


    public void TheEnd()
    {
        endPopUp.SetActive(true);
        ToggleTime(false);
}

    public void Debugg()
    {
        Debug.Log("Debug");
    }
    public void FixedUpdate()
    {
        #region switch
        if (Input.GetAxisRaw("Switch") == 1 && !justSwitched)
        {
            justSwitched = true;
            SwitchPlaces();
        }
        else if(Input.GetAxisRaw("Switch")==0)
        {
            justSwitched = false;
        }
        #endregion
    }

    //bedzie do wywalenia
    private Vector3 coordy = new Vector3(15, 1, 0);

    private void Awake()
    {
        //CreateDictionary();
        if (GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        //DontDestroyOnLoad(gameObject);

    }

    public void ToggleTime(bool timeRuns)
    {
        if (timeRuns)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }

    public void LoadMainMenu()
    {
        ToggleTime(true);
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");

    }

    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    }

    public void ShowItem(string msg, int fontSize, Color color, Image img)
    {
        popUpItemManager.Show(msg, fontSize, color, img);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        Time.timeScale = 1;
        Debug.Log("SceneLoaded");
    }


    public void SwitchPlaces()
    {
        if (canSwitch)
        {
            player.ToggleMoving();
            reflection.ToggleMoving();
            followPlayer = !followPlayer;
            Debug.Log("Switcherro");
        }

    }

}
