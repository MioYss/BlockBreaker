using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Brick_Manager : MonoBehaviour
{

    public int brick_pv = 1;

    public GameObject Brick;
    public SpriteRenderer BrickRenderer;

    public GameObject spawn_bonus_joueur;

    public Transform parent_ennemies;

    public Game_Manager manager;


    public Color[] color_array = new Color[] {Color.blue, Color.green, Color.red};

    public void Start()
    {
        manager = FindObjectOfType<Game_Manager>();

    }

    public void Update()
    {
        BrickRenderer.color = color_array[brick_pv - 1];
    }


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
        Debug.Log(brick_pv);

        

        manager.score += 100;

        if (brick_pv <= 0)
        {
            Destroy(this.gameObject);
            Instantiate(spawn_bonus_joueur, parent_ennemies.position, Quaternion.identity);
        }
    }

    // pour faire en sorte que les couleurs soient associ�es a un certain nombre de pv de la brique : creer tableau de couleurs avec comme indice chaque pv a peu pres
    // tab[blue, orange, red] en gros
    // BrickRenderer.color = tab[brick_pv -1];
    // se renseigner sur comment on ecrit les liste en c# jai oubli�
}
