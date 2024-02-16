using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointCounter : MonoBehaviour
{

    public Text scoreText;
    int score = 0;
    public static PointCounter instance;



    private void Awake()
    {
        instance = this;
        
    }

    private void Start()
    {
        scoreText.text = score.ToString();


    }


    public void addScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
}
