using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEndFireScript : MonoBehaviour
{
    void OnEnable()
    {
        GameManager.instance.TheEnd();       
    }
}
