using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    public static int playerHealth;
    public static int numberOfHearts;


    public static void Save()
    {
        PlayerPrefs.SetInt("playerHealth", playerHealth);
        PlayerPrefs.SetInt("numberOfHearts", numberOfHearts);

    }
    public static void Load()
    {
        playerHealth = PlayerPrefs.GetInt("playerHealth", 3);
        numberOfHearts = PlayerPrefs.GetInt("numberOfHearts", 3);

    }
    [RuntimeInitializeOnLoadMethod]
    static void Startup()
    {

        Debug.Log("Load Save File");
        Load();
    }
    


}
