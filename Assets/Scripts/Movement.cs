using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveInputx;
    public float moveInputy;
    public int moveSpeed;
    void Update()
    {
        Moving();
    }
    void Moving()
    {

        moveInputx = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInputx * moveSpeed, rb.velocity.y);
        rb.velocity = new Vector2(moveInputy * moveSpeed, rb.velocity.x);
        

    }

}
