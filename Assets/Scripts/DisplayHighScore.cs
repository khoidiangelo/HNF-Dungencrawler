using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighScore : MonoBehaviour
{
    public Text highScore;

    private void Update()
    {
        highScore.text = Globals.highScore.ToString("F0");
    }
}