using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject deadPanel;

    private void Awake()
    {
        instance = this;
    }
    
    public void has_died()
    {
        Globals.currentScore = 0;
        Globals.healPotion = 0;
        Time.timeScale = 1;
        deadPanel.SetActive(true);
    }
}
