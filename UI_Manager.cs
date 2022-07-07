using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private Text textPunts;


    // Update is called once per frame
    void Update()
    {
        textPunts.text = "Puntuacio: " + GameManager.singleton.puntuacio;
    }
}
