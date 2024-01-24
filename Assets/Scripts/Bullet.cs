using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Brick_Manager Brick;

    public Rigidbody2D bullet_rb;

    public float speed;

    private void Start()
    {
        bullet_rb.velocity = Vector2.up * 20;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var brick = collision.gameObject.GetComponent<Brick_Manager>();
        if (brick)
        {            
            Brick.Perte_PV_Brick();
            Destroy(this.gameObject);
        }
    }


}
