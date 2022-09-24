using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour
{
    public GameObject pausePanel;
    private bool pauseIsActive = false;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && pauseIsActive == false)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
            pauseIsActive = true;

        }
        if(Input.GetKeyDown(KeyCode.Escape) && pauseIsActive == true)
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
            pauseIsActive = false;

        }
        
       
        
    }
    private void OnApplicationQuit()
    {

        Globals.Save();
        Debug.Log("Save Game");
    }
}
