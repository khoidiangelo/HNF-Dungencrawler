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
    public Animator animator;
    private Vector2 movement;



    protected void Move()
    {
        Debug.Log(Vector3.forward);
        movement = Vector3.forward;
        Debug.Log(movement);
        animator.SetFloat("horizontal speed", movement.x);
        animator.SetFloat("vertical speed",  movement.y);
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
