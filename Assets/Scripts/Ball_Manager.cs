using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball_Manager : MonoBehaviour
{


    //public GameObject ball;

    private GameObject current_ball;
    public Rigidbody2D ball_rigidbody;

    public Vector2 speed;

    private Vector2 _direction;

    public Transform limit_L;
    public Transform limit_R;
    public Transform limit_H;
    public Transform limit_B;


    // Start is called before the first frame update
    void Start()
    {
        //current_ball = Instantiate(ball);
        

        speed.x = 0f;
        speed.y = -20f;

        ball_rigidbody.velocity = speed;


    }

    // Update is called once per frame
    void Update()
    {

        // verif de la pos de la balle par rapport a l'interieur de l'ecran

        if (transform.position.x < limit_L.position.x)
        {
            speed.x = 20f;
            speed.y = 0f;

            ball_rigidbody.velocity = speed;
        }
        if (transform.position.x > limit_R.position.x)
        {
            speed.x = -20f;
            speed.y = 0f;

            ball_rigidbody.velocity = speed;
        }


        if (transform.position.y < limit_B.position.y)
        {
            SceneManager.LoadScene("SampleScene");
            
        }
        if (transform.position.y > limit_H.position.y)
        {
            speed.x = 0f;
            speed.y = -20f;

            ball_rigidbody.velocity = speed;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed.x = -speed.x;
        speed.y = -speed.y;

        ball_rigidbody.velocity = speed;
        Debug.Log("touche tout court");

        // si la collision est avec la barre
       /* if (collision.gameObject.CompareTag("Barre"))
        {
            Debug.Log("touche barre");
            

        }*/
    }



    //TODO: rebondir sur la platerforme, detruire une brique lorsqu'il y a collision, augmentation des points, changement dangle selon la position du rebond
}
