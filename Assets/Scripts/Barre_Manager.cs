using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bar_Mouvement : MonoBehaviour
{
    public float speed = 0.4f;
    public Transform limit_L;
    public Transform limit_R;

    public Transform parent_L;
    public Transform parent_R;
    public Bullet Bullet_Shoot;

    public Vector2 spawn_L, spawn_R;


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed;
        }

        if (transform.position.x < limit_L.position.x)
        {
            transform.position = new Vector3(limit_R.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limit_R.position.x)
        {
            transform.position = new Vector3(limit_L.position.x, transform.position.y, transform.position.z);
        }


        spawn_L.x = parent_L.position.x - 2;
        spawn_L.y = parent_L.position.y;

        spawn_R.x = parent_R.position.x + 2;
        spawn_R.y = parent_R.position.y;


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // prend le power up
        Debug.Log("power up actif");

        if (other.gameObject.tag == "Power_Up")
        {
            Bullet_Shoot.gameObject.SetActive(true);
            Power_Up_Tir();

            Destroy(other.gameObject);
        }

    }
    public void Power_Up_Tir()
    {
        Debug.Log("power up activer mama");
        Bullet_Shoot.gameObject.SetActive(true);
        StartCoroutine(Temps_De_Tir());
    }
    public IEnumerator Temps_De_Tir()
    {
        Debug.Log("power up activer mama2");
        for (int i = 0; i <= 10; i++)
        {

            

            var bL = Instantiate(Bullet_Shoot, spawn_L, parent_L.rotation);
            var bR = Instantiate(Bullet_Shoot, spawn_R, parent_R.rotation);

            yield return new WaitForSeconds(0.5f);
        }


    }
}
