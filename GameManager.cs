using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int puntuacio;

    public static GameManager singleton;
    // Start is called before the first frame update

    void Awake()
    {
        if(singleton == null)
            singleton = this;
        else if (singleton != this)
            Destroy(gameObject);
    }

    public void AfegirPunts(int punts)
    {
        puntuacio += punts;
    }
}