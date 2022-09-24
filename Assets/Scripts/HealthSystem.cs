using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    
   
   
    public int healPotion;
    public Image[] hearts;
    public Sprite emptyHeart;
    public Sprite fullHeart;

    public GameObject deadPanel;
    
    private void Start()
    {
        Globals.playerHealth = Globals.numberOfHearts;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Globals.playerHealth -= 1;
        }
        
        HealPotion();

        if (Globals.playerHealth > Globals.numberOfHearts)
        {
            Globals.playerHealth = Globals.numberOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Globals.playerHealth)
            {
                if (hearts[i] != null)
                {
                    hearts[i].sprite = fullHeart;
                }


            }
            else
            {
                if (hearts[i] != null)
                {
                    hearts[i].sprite = emptyHeart;
                }

            }
            if (i < Globals.numberOfHearts)
            {
                if (hearts[i] != null)
                {
                    hearts[i].enabled = true;
                }


            }
            else
            {
                if (i < Globals.numberOfHearts)
                {
                    hearts[i].enabled = false;
                }

            }

        }
        if (Globals.playerHealth <= 0)
        {
            Globals.dead = 1;
            if(Globals.dead == 1)
            {
                Time.timeScale = 0;
                deadPanel.SetActive(true);

            }
        }
        
    }
    void HealPotion()
    {
        if (Input.GetKeyDown(KeyCode.H) && Globals.healPotion > 0 && Globals.playerHealth != 3)
        {
            Globals.playerHealth += 1;
            Globals.healPotion -= 1;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemyAttack"))
        {
            Globals.playerHealth -= 1;
        }
        if(collision.gameObject.CompareTag("border"))
        {
            Globals.playerHealth -= 3;
        }
    }
    

}
