using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick_Manager : MonoBehaviour
{

    public int brick_pv = 1;

    public GameObject Brick;

    public GameObject spawn_bonus_joueur;

    public Transform parent_ennemies;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Perte_PV_Brick();
        }

    }

    public void Perte_PV_Brick ()
    {
        brick_pv--;

        if (brick_pv >= 0)
        {
            Destroy(this.gameObject);
            Instantiate(spawn_bonus_joueur, parent_ennemies.position, Quaternion.identity);
        }
    }


}
