using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static Movement Instance;
    public float moveSpeed = 5;
    public Rigidbody2D rb;

    Vector2 movement;
    internal Animator animator;
    internal Animator swordAnimator;
    public Vector2 Direction;
    public GameObject Sword;
    public bool isHitting;
    private void Awake()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        swordAnimator = Sword.GetComponent<Animator>();
    }
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("horizontal speed", movement.x);
        animator.SetFloat("vertical speed", movement.y);
        
        if (movement.sqrMagnitude > 0)
        {
            if (Mathf.Abs(movement.x) > Mathf.Abs(movement.y))
            {
                if (movement.x > 0)
                {
                    Direction = new Vector2(1f, 0f);
                    
                    Sword.transform.localPosition = new Vector3(0.085f,-0.017f,0f);
                    Sword.transform.localRotation = Quaternion.Euler(new Vector3(0f,0f,80f));
                    Sword.gameObject.GetComponent<SpriteRenderer>().flipX = true;
                    Sword.gameObject.GetComponent<SpriteRenderer>().flipY = true;
                }
                else
                {
                    Direction = new Vector2(-1f, 0f);
                    Sword.transform.localRotation = Quaternion.Euler(new Vector3(0f,0f,80f));
                    Sword.transform.localPosition = new Vector3(-0.085f,-0.004f,0f);
                    Sword.gameObject.GetComponent<SpriteRenderer>().flipX = false;
                    Sword.gameObject.GetComponent<SpriteRenderer>().flipY = false;
                    //left
                }
            }
            else 
            {
                if (movement.y > 0)
                { 
                    Direction = new Vector2(0f, 1f);
                    Sword.transform.localRotation = Quaternion.Euler(new Vector3(0f,0f,-176.232f));
                    Sword.transform.localPosition = new Vector3(0.013f,0.125f,0f);
                    Sword.gameObject.GetComponent<SpriteRenderer>().flipY = true;
                    Sword.gameObject.GetComponent<SpriteRenderer>().flipX = false;

                    
                    //down
                }
                else
                {
                    Direction = new Vector2(0f, -1f);
                    Sword.transform.localRotation = Quaternion.Euler(new Vector3(0f,0f,-0.231f));
                    Sword.transform.localPosition = new Vector3(0.003f,-0.107f,0f);
                    Sword.gameObject.GetComponent<SpriteRenderer>().flipY = true;
                     Sword.gameObject.GetComponent<SpriteRenderer>().flipX = false;

                    //up
                }
            }
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
