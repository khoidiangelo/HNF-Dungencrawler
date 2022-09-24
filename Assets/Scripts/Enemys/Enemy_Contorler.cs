using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Contorler : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    public int health;
    public Transform Sprite;
    protected void Move()
    {
        agent.destination = target.position;
        Sprite.position = this.gameObject.transform.position;

    }
    public void Damage(int damage)
    {
        this.health -= damage;
        if (health < 0)
        {
            Destroy(this.transform.parent.gameObject);
        }
    }

}
