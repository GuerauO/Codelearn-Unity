using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class ballBehaviour : MonoBehaviour
{

    public Rigidbody rb;
    public float bounce = 6;

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(rb.velocity.x, bounce, rb.velocity.z);

        if(collision.gameObject.tag == "ENEMY")
        {
            transform.SetPositionAndRotation(new Vector3(-2f, 20.0f, 0.0f), Quaternion.identity);
            rb.velocity = new Vector3(0, 2, 0);
        }
        
        if (collision.gameObject.tag == "END")
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
