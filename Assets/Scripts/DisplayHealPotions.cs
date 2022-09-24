using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayHealPotions : MonoBehaviour
{
    public Text displayHealPotions;
    private void Update()
    {
        healPotionsDisplay();
    }

    void healPotionsDisplay()
    {
        displayHealPotions.text = Globals.healPotion.ToString();
    }
}
