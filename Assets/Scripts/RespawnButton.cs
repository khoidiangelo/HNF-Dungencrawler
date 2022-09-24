using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnButton : MonoBehaviour
{
    public GameObject deadPanel;
    public GameObject respawnPoint;
    public GameObject player;
    public void Respawn()
    {
        Time.timeScale = 1;
        deadPanel.SetActive(false);
        player.transform.position = respawnPoint.transform.position;
        Globals.playerHealth = Globals.numberOfHearts;
    }
}
