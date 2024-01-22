using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Manager : MonoBehaviour
{


    GameObject current_ball;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(current_ball);
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    //TODO: rebondir sur la platerforme, detruire une brique lorsqu'il y a collision, augmentation des points, changement dangle selon la position du rebond
}
