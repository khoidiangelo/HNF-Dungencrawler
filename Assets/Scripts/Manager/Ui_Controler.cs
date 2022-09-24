using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_Controler : MonoBehaviour
{
    public static Ui_Controler instance;

    public Transform hearts_Positions;
    public GameObject[] hearts_UI;
    public GameObject Heart_Sprite;

    public Sprite emptyHeart_sprite;
    public Sprite fullHeart_sprite;
    public int heart_offset;

    public GameObject deadPanel;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        hearts_UI = new GameObject[HealthSystem.instance.max_Health];
        for (int i = 0; i < hearts_UI.Length; i++)
        {
            GameObject new_Heart = Instantiate(this.Heart_Sprite, new Vector3(hearts_Positions.position.x + i * heart_offset, hearts_Positions.position.y , hearts_Positions.position.z) , hearts_Positions.rotation , hearts_Positions);
            hearts_UI[i] = new_Heart;
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void render_Hearts(int no_of_Hearts)
    {
        for (int i = 0; i < HealthSystem.instance.max_Health; i++)
        {
            if (hearts_UI[i] != null)
            {

                if (i < no_of_Hearts)
                {
                    hearts_UI[i].GetComponent<Image>().sprite = fullHeart_sprite;
                }
                else
                {
                    hearts_UI[i].GetComponent<Image>().sprite = emptyHeart_sprite;
                }
            }
        }
    }
    public void render_take_Damage()
    {
        //to do Schow red aura for taking damage
    }
}
