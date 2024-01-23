using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform parent;

    public GameObject Bullet_Shoot;

    public Brick_Manager Brick;

    public void Power_Up_Tir()
    {
        Debug.Log("power up activer mama");
        Temps_De_Tir();
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Brick")
        {            
            Brick.Perte_PV_Brick();
            Destroy(this.gameObject);
        }
    }

    public IEnumerator Temps_De_Tir()
    {
        Debug.Log("power up activer mama2");
        for(int i = 0; i <= 10; i++)
            //Instantiate(Bullet_Shoot, Vector2 (x, y, 0), Quaternion.identity);;
            //Instantiate(Bullet_Shoot, parent.position + Vector2.left*0.5f, parent.rotation);
            yield return new WaitForSeconds(0.5f);
    }
}
