using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game_Manager : MonoBehaviour
{

    public int score;
    public float time;

    public TextMeshProUGUI score_text;
    public TextMeshProUGUI time_text;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        time = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "" + score;

        time += Time.deltaTime;

        time_text.text = time.ToString("0.0");
    }
}
