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

    public void Start()
    {
        this.player = HealthSystem.instance.gameObject;
    }
    public void Respawn()
    {
        nextDungeon = Random.Range(1, 4);
        Globals.Save();
        Debug.Log("save");
        SceneManager.LoadScene(nextDungeon);
        Debug.Log(nextDungeon);
        Time.timeScale = 1;
        deadPanel.SetActive(false);
        player.transform.position = respawnPoint.transform.position;
        Globals.playerHealth = Globals.numberOfHearts;
    }
}
