using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsSwitch : MonoBehaviour
{
    public GameObject object01;
    public GameObject object02;
    public GameObject object03;

    public Inventory inventari;

    


    void Start()
    {
        object01.SetActive(false);
        object02.SetActive(false);
        object03.SetActive(false);

    }




    void Update()
    {
        if(Input.GetButtonDown("1"))
        {
            object01.SetActive(false);
            object02.SetActive(false);
            object03.SetActive(false);
        }

        if (Input.GetButtonDown("2") && inventari.item1 == true)
        {
            object01.SetActive(true);
            object02.SetActive(false);
            object03.SetActive(false);
        }

        if (Input.GetButtonDown("3") && inventari.item2 == true)
        {
            object01.SetActive(false);
            object02.SetActive(true);
            object03.SetActive(false);
        }

        if (Input.GetButtonDown("4") && inventari.item3 == true)
        {
            object01.SetActive(false);
            object02.SetActive(false);
            object03.SetActive(true);
        }


    }
}
