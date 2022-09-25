using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text scoreText;
    public GameObject player;
    

    private void Start()
    {
        
    }

    private void Update()
    {
        
        
        scoreText.text = Globals.currentScore.ToString("F0");
    }
}
