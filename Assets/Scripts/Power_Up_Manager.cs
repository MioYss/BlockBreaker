using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_Up_Manager : MonoBehaviour
{

    public GameObject Power_Up;
// Pour détruire les power up quand ils sortent de l'écran
    void OnTriggerEnter2D (Collider2D other) 
    {
        if (other.gameObject.tag == "Destruction")
        {
            Debug.Log("touche limitb");
            Destroy(this.gameObject);
        }
    }

}
