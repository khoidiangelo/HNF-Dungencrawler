using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour
{
    private void OnApplicationQuit()
    {

        Globals.Save();
        Debug.Log("Save Game");
    }
}
