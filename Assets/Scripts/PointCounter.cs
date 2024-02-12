using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointCounter : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public static PointCounter instance;


    //[ContextMenu("Increase Score")]

    private void Awake()
    {
        instance = this;
        
    }

    private void Start()
    {

        //scoreText = GetComponent<Text>();

    }


    public void addScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();
    }
}
