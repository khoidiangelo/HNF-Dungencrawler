using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Contorler : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    public int health;
    protected void Move()
    {
        agent.destination = target.position;
    }
    public void Damage(int damage)
    {
        this.health -= damage;
        if (health < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
