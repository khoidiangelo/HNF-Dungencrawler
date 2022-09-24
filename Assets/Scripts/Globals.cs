using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    public static int playerHealth;
    public static int numberOfHearts;
    public static int healPotion;
    public static int dead;
    public static float highScore;


    public static void Save()
    {
        PlayerPrefs.SetInt("playerHealth", playerHealth);
        PlayerPrefs.SetInt("numberOfHearts", numberOfHearts);
        PlayerPrefs.SetInt("healPotion", healPotion);
        PlayerPrefs.SetInt("dead", dead);
        PlayerPrefs.SetFloat("highScore", highScore);

    }
    public static void Load()
    {
        playerHealth = PlayerPrefs.GetInt("playerHealth", 3);
        numberOfHearts = PlayerPrefs.GetInt("numberOfHearts", 3);
        healPotion = PlayerPrefs.GetInt("healPotion", 1);
        dead = PlayerPrefs.GetInt("dead", 0);
        highScore = PlayerPrefs.GetFloat("highScore", highScore);
    }
    [RuntimeInitializeOnLoadMethod]
    static void Startup()
    {

        Debug.Log("Load Save File");
        Load();
    }
    


}