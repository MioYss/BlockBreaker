using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_Up_Manager : MonoBehaviour
{

    public GameObject Power_Up;

    void OnTriggerEnter2D (Collider2D other) 
    {
        if (other.gameObject.tag == "Destruction")
        {
            Debug.Log("touche limitb");
            Destroy(this.gameObject);
        }
    }

}
