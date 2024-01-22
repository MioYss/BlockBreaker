using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Manager : MonoBehaviour
{


    //public GameObject ball;

    private GameObject current_ball;
    public Rigidbody2D ball_rigidbody;

    public Vector2 speed;



    // Start is called before the first frame update
    void Start()
    {
        //current_ball = Instantiate(ball);
        

        speed.x = 0f;
        speed.y = 1000f;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("touche tout court");

        // si la collision est avec la barre
        if (collision.gameObject.CompareTag("Barre"))
        {
            Debug.Log("touche barre");
            ball_rigidbody.AddForce(speed);

        }
    }



    //TODO: rebondir sur la platerforme, detruire une brique lorsqu'il y a collision, augmentation des points, changement dangle selon la position du rebond
}
