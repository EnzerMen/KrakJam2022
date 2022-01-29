using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;
    public Reflection reflection;
    public GameObject character;
    public GameObject cameraPref;
    public FloatingTextManager floatingTextManager;
    public bool canSwitch = false;
    private bool justSwitched = false;
    public bool followPlayer = true;


    public bool [] hasAnItem = new bool[10]; //lista przedmiotów mam/niemam
    public Vector3[] doorCoords = new Vector3[10]; //coordy po przejsciu przez drzwi
    public int usedDoorID; //ktore drzwi zostaly uzyte
   
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
        if(GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
        
    }


    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
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

        Debug.Log("SceneLoaded");
    }

}
