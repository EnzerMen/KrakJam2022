using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;
    public GameObject character;
    public GameObject cameraPref;

    public bool [] hasAnItem = new bool[10]; //lista przedmiotów mam/niemam
    public Vector3[] doorCoords = new Vector3[10]; //coordy po przejsciu przez drzwi
    public int usedDoorID; //ktore drzwi zostaly uzyte
   
    
    
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
        if (scene.name == "SampleScene")
        {
            Instantiate(character, coordy, player.transform.rotation);
        }
        else
        {
            Instantiate(character, doorCoords[usedDoorID], player.transform.rotation); //spawn postaci w coordach zaleznych od drzwi
        }

        



        Instantiate(cameraPref);
    }

}
