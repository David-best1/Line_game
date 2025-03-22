using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private KeyCode jumpKey;
    [SerializeField] private SpriteRenderer player;


    [SerializeField] private Animator animator;
    private Rigidbody2D rb;

    float moveX;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);

        if (moveX < 0)
        {
            player.flipX = true;
        }
        else
        {
            player.flipX = false;
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
