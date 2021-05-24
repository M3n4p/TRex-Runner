using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;

    public float jumpStrength = 5f;
    bool grounded = true;

    public GameManager manager;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        animator.SetBool("isJumping", !grounded);
    }

    private void FixedUpdate()
    {
        if(Input.GetAxisRaw("Jump") > 0 && grounded)
        {
            grounded = false;
            rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
            rb.gravityScale = 2f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            grounded = true;
            rb.gravityScale = 1f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.enabled = false;
        manager.IsDead = true;
    }
}
