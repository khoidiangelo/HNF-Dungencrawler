using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public int numberOfHearts;
    public int healPotion;
    public Image[] hearts;
    public Sprite emptyHeart;
    public Sprite fullHeart;
    private void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
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
    }
    void HealPotion()
    {
        if (Input.GetKeyDown(KeyCode.H))
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
    }
    

}
