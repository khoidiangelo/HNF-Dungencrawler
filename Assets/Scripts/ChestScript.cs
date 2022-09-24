using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    

    private void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Globals.healPotion += 1;
        Destroy(gameObject);
    }
}
