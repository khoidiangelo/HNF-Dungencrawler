using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayHealPotions : MonoBehaviour
{
    public Text displayHealPotions;
    
    void healPotionsDisplay()
    {
        displayHealPotions.text = Globals.healPotion.ToString();
    }
}
