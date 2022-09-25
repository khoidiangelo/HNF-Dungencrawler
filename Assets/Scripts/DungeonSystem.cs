using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DungeonSystem : MonoBehaviour
{
    public GameObject[] Zombies;
    private int nextDungeon;

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
            nextDungeon = Random.Range(1, 4);
            Globals.Save();
            Debug.Log("Save");
            SceneManager.LoadScene(nextDungeon);
            Debug.Log(nextDungeon);
            
        }
    }
}
