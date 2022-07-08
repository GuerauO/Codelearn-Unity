using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumaPunts : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider pilota)
    {
        GameManager.singleton.AfegirPunts(1);
    }

}
