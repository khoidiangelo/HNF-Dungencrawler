using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSwordAnimation : MonoBehaviour
{
    public GameObject Sword;
    private Animator animator;
    // Start is called before the first frame update
    private void Awake()
    {
        animator = Sword.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {

            animator.SetInteger("Horrizontal" ,(int)Movement.Instance.Direction.x);

            animator.SetInteger("Vertical" , (int)Movement.Instance.Direction.y);


            animator.SetTrigger("attack");
        }
    }
}
