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
    public GameObject Bullet_Shoot;


    private Vector2 spawn_L, spawn_R;


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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // prend le power up
        Debug.Log("power up actif");

        Bullet_Shoot.SetActive(true);
        Power_Up_Tir();

        Destroy(collision.gameObject);
    }
    public void Power_Up_Tir()
    {
        Debug.Log("power up activer mama");
        Bullet_Shoot.SetActive(true);
        StartCoroutine(Temps_De_Tir());
    }
    public IEnumerator Temps_De_Tir()
    {
        Debug.Log("power up activer mama2");
        for (int i = 0; i <= 10; i++)
        {

            spawn_L.x = parent_L.position.x;
            spawn_L.y = parent_L.position.y - 8.66f;

            spawn_R.x = parent_R.position.x;
            spawn_R.y = parent_R.position.y - 8.66f;

            Instantiate(Bullet_Shoot, spawn_L, parent_L.rotation);

            Instantiate(Bullet_Shoot, spawn_R, parent_R.rotation);
            yield return new WaitForSeconds(0.5f);
        }


    }
}
