using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text scoreText;
    public GameObject player;
    private float currentScore;

    private void Start()
    {
        
    }

    private void Update()
    {
        currentScore = player.GetComponent<General>().currentScore;
        
        scoreText.text = currentScore.ToString("F0");
    }
}
