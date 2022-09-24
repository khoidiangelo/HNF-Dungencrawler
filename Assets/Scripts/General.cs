using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour
{
    public GameObject pausePanel;
    private bool pauseIsActive = false;
    public float currentScore;
    
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseIsActive == false)
            {
                Debug.Log("pause");
                pausePanel.SetActive(true);
                Time.timeScale = 0;
                pauseIsActive = true;
            }
            else
            {
                Debug.Log("unpause");
                pausePanel.SetActive(false);
                Time.timeScale = 1;
                pauseIsActive = false;
            }

        }
        HighScoreSystem();
        
    }
    private void OnApplicationQuit()
    {

        Globals.Save();
        Debug.Log("Save Game");
    }
    void HighScoreSystem()
    {
        currentScore += Time.deltaTime;
        if(currentScore > Globals.highScore)
        {
            Globals.highScore = currentScore;
        }
    }
}