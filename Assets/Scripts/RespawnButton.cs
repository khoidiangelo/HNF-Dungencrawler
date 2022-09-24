using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnButton : MonoBehaviour
{
    public GameObject deadPanel;
    public GameObject respawnPoint;
    public GameObject player;
    public int nextDungeon;
    public void Respawn()
    {
        nextDungeon = Random.Range(1, 4);
        SceneManager.LoadScene(nextDungeon);
        Debug.Log(nextDungeon);
        Time.timeScale = 1;
        deadPanel.SetActive(false);
        player.transform.position = respawnPoint.transform.position;
        Globals.playerHealth = Globals.numberOfHearts;
    }
}
