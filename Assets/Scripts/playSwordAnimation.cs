using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSwordAnimation : MonoBehaviour
{
    internal Animator animator;
    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            animator.SetBool("ifAttacking", true);
        }
    }
}
