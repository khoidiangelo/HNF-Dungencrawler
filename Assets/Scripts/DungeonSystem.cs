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
        if(Zombies == null)
        {
            nextDungeon = Random.Range(1, 2);
            Debug.Log(nextDungeon);
            SceneManager.LoadScene(nextDungeon);
            
        }
    }
}
