using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class rebotPilota : MonoBehaviour
{
    public Rigidbody rb;
    public float rebot = 6;
    

    public GameObject splash;   //NOU!!

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(rb.velocity.x, rebot, rb.velocity.z);

        afegeixSplash(collision);

        if(collision.gameObject.tag == "ENEMIC")
        {
            transform.SetPositionAndRotation(new Vector3(0.0f,30.0f,2.0f), Quaternion.identity);
            GameManager.singleton.ResetejarPunts();
        }

        if(collision.gameObject.tag == "FIANL")
        {
            SceneManager.LoadScene("Nivell 2"); //(1)
        }

         if(collision.gameObject.tag == "FinalNivell2")
        {
            SceneManager.LoadScene("Nivell 3");
        }

        

    }

        
    public void afegeixSplash(Collision collision)
    {
        GameObject newSplash;

        newSplash = Instantiate(splash);

        newSplash.transform.SetParent(collision.transform);
        
        newSplash.transform.position = new Vector3(this.transform.position.x,
                                                   this.transform.position.y-0.56f,
                                                   this.transform.position.z);

        Destroy(newSplash, 3);
    }



}
