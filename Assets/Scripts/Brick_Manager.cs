using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick_Manager : MonoBehaviour
{

    int brick_pv = 1;

    public GameObject Brick;
    private void OnCollisionEnter2D(Collision2D brick)
    {

            Debug.Log("hit");
            Perte_PV_Brick();
    }

    public void Perte_PV_Brick ()
    {
        if (GameObject.FindWithTag("Brick_01"))
        {
            brick_pv--;

            if (brick_pv >= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
