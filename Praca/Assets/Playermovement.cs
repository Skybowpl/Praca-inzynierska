using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    private float horizontal;

    [SerializeField] private float speed;
    [SerializeField] private float jumpHigh;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHigh);
        }

        if (Input.GetMouseButton(0) == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        if (Input.GetMouseButton(0) == false)
        {
            rb.constraints = ~RigidbodyConstraints2D.FreezePosition;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        if(horizontal>0)
        {
            gameObject.transform.localScale = new Vector3(1,1,1);
        }
        if(horizontal<0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapBox(groundCheck.position, new Vector2(0.9f, 0.1f), 0f, groundLayer);
    }
}
