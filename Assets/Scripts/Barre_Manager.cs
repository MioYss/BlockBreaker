using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar_Mouvement : MonoBehaviour
{
    public float speed = 0.4f;
    public Transform limit_L;
    public Transform limit_R;
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
}
