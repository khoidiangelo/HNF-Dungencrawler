using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthSystem : MonoBehaviour
{
    public static HealthSystem instance;


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
        {
            invinceileCount -= Time.deltaTime;
        }

        
        if (current_Health <= 0)
        {
            GameManager.instance.has_died();
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
        {
            this.DamagePlayer(-1);
        }
    }
   
    

}
