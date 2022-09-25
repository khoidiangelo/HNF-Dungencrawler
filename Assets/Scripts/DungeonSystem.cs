using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DungeonSystem : MonoBehaviour
{
    public GameObject[] Zombies;
    private int nextDungeon;
    public GameObject fader;

    private IEnumerator coroutine;
    private void Update()
    {
        bool gonext = true;
        for(int i = 0; i < Zombies.Length; i++)
            {
                if(Zombies[i] != null)
                {
                    gonext = false;
                }
            }

        if(gonext)
        {
            Time.timeScale = 0;
            fader.SetActive(true);
            fader.GetComponent<RawImage>().color = new Color(0,0,0,Mathf.Lerp(0f,1f,0.05f));
            nextDungeon = Random.Range(1, 4);
            Globals.Save();
            Debug.Log("Save");
            SceneManager.LoadScene(nextDungeon);
            Debug.Log(nextDungeon);
            
        }
    }
}
