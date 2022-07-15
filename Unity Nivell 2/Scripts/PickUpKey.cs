using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public GameObject keyOB;
    public GameObject invOB;
    public GameObject invOB_2;

    public GameObject pickUpText;
    public AudioSource keySound;

    public Inventory inventari;

    public bool inReach;


    void Start()
    {
        inReach = false;
        pickUpText.SetActive(false);
        invOB.SetActive(false);
        invOB_2.SetActive(false);

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            pickUpText.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            pickUpText.SetActive(false);

        }
    }


    void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            keyOB.SetActive(false);
            keySound.Play();
            invOB.SetActive(true);
            invOB_2.SetActive(true);

            inventari.item1 = true;
            pickUpText.SetActive(false);
        }

        
    }
}
