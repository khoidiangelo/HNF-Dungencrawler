using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack_System : MonoBehaviour
{
    Weapons weapon = Weapons.Sword;
    public float Attack_Range_Sword;
    public int Attack_Angle_Sword;
    public int Attack_Damage_Sword;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            switch (weapon)
            {
                case Weapons.Sword:
                    SwordAttack();
                    break;
            }
        }
    }
    public void SwordAttack()
    {
        Vector2 current_2D_Pos = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);
        Collider2D collision = Physics2D.OverlapCircle(current_2D_Pos, Attack_Range_Sword);
        Debug.Log(collision.gameObject.name);
        //Debug.Log(Vector2.Angle(Movement.Instance.Direction, new Vector2(current_2D_Pos.x - collision.gameObject.transform.position.x, current_2D_Pos.y - collision.gameObject.transform.position.y)));
        if (Vector2.Angle(Movement.Instance.Direction, new Vector2(current_2D_Pos.x - collision.gameObject.transform.position.x, current_2D_Pos.y - collision.gameObject.transform.position.y))<Attack_Angle_Sword)
        {
            Debug.Log("right Angle");
            if (collision.gameObject.CompareTag("Enemy"))
            {
                collision.gameObject.GetComponent<Enemy_Contorler>().Damage(Attack_Damage_Sword);
            }
        }
    }
}
public enum Weapons
{
    None,
    Sword
}