using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthSystem : MonoBehaviour
{
    
   
   
    public int healPotion;
    public Image[] hearts;
    public Sprite emptyHeart;
    public Sprite fullHeart;


    public int max_Health;
    public float invincibleTime = 0.5f;

    public int numberOfHearts;

    public int current_Health;

    public int storred_healPotions;

    public float invinceileCount;


    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
 
        current_Health = max_Health;

    }

    void Update()
    {
        check_HealPotion();

        if (invinceileCount >= 0)

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            Globals.playerHealth -= 1;
        }
        
        HealPotion();

        if (Globals.playerHealth > Globals.numberOfHearts)
 
        {
            invinceileCount -= Time.deltaTime;
        }

        
        if (current_Health <= 0)
        {
 
            GameManager.instance.has_died();

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
                Globals.healPotion = 0;
                Time.timeScale = 0;
                deadPanel.SetActive(true);

            }
 
        }
        
    }



    public void DamagePlayer(int damageAmount)
    {
 
        if (invinceileCount <= 0)
        {
            current_Health -= damageAmount;

            Ui_Controler.instance.render_take_Damage();

            if (current_Health <= 0)
            {
                gameObject.SetActive(false);

                current_Health = 0;

                GameManager.instance.has_died();
            }

            invinceileCount = invincibleTime;
        }

        Ui_Controler.instance.render_Hearts(current_Health);
    }
    void check_HealPotion()
    {

        if (Input.GetKeyDown(KeyCode.H))

        if (Input.GetKeyDown(KeyCode.H) && Globals.healPotion > 0 && Globals.playerHealth != 3)
 
        {
            this.DamagePlayer(-1);
        }
    }
   
    

}