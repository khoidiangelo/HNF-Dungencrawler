using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static Movement Instance;
    public float moveSpeed = 5;
    public Rigidbody2D rb;

    Vector2 movement;
    public Vector2 Direction;

    private void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (movement.sqrMagnitude > 0)
        {
            if (Mathf.Abs(movement.x) > Mathf.Abs(movement.y))
            {
                if (movement.x > 0)
                {
                    Direction = new Vector2(1f, 0f);
                }
                else
                {
                    Direction = new Vector2(-1f, 0f);
                }
            }
            else 
            {
                if (movement.y > 0)
                {
                    Direction = new Vector2(0f, 1f);
                }
                else
                {
                    Direction = new Vector2(0f, -1f);
                }
            }
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
