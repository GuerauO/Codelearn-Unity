using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class rebotPilota : MonoBehaviour
{
    public Rigidbody rb;
    public float rebot = 6;
    
    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(rb.velocity.x, rebot, rb.velocity.z);
        
        if(collision.gameObject.tag == "ENEMIC")
        {
            transform.SetPositionAndRotation(new Vector3(0.0f,30.0f,2.0f), Quaternion.identity);
        }
    }


}
