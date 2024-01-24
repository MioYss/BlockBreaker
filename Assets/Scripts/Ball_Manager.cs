using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball_Manager : MonoBehaviour
{


    //public GameObject ball;

    private GameObject current_ball;
    public Rigidbody2D ball_rigidbody;

    public Transform barre_transform;
    public Transform ball_transform;

    public Vector2 speed;

    private float hit_pos;

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

            ball_rigidbody.velocity = speed;
        }
        if (transform.position.x > limit_R.position.x)
        {
            speed.x = -20f;

            ball_rigidbody.velocity = speed;
        }


        if (transform.position.y < limit_B.position.y)
        {
            SceneManager.LoadScene("SampleScene");
            
        }
        if (transform.position.y > limit_H.position.y)
        {
            speed.y = -20f;

            

        }

        if (speed.y == 0f)
        {
            speed.y = 1f;
        }

        ball_rigidbody.velocity = speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // si la collision est avec la barre
        if (collision.gameObject.CompareTag("Barre"))
        {
            hit_pos = barre_transform.position.x - ball_transform.position.x;

            Debug.Log("hit pos = " + hit_pos);


            speed.x = -hit_pos*hit_pos*hit_pos*5;
            speed.y = -speed.y;
        }

        else
        {
            speed.x = -speed.x;
            speed.y = -speed.y;

            
            Debug.Log("touche tout court");
        }
        ball_rigidbody.velocity = speed;
    }
}
