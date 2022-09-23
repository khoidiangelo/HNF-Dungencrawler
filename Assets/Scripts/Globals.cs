using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    


    public static void Save()
    {
        

    }
    public static void Load()
    {
        

    }
    [RuntimeInitializeOnLoadMethod]
    static void Startup()
    {

        Debug.Log("Load Save File");
        Load();
    }
    


}
