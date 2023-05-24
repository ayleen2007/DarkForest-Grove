using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private float moveDirection;
    public float jumpForce;
    public LayerMask groundobjects;
    public float checkRadius;
    public int maxJumpCount;

    public bool isGrounded;
    public Transform groundCheck;
    public Transform ceilingCheck;

    private bool isJumping = false;
    private int jumpCount;

    //Awake
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        jumpCount = maxJumpCount;
    }

    private void FixedUpdate()
    {
        //check
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundobjects);
        if (isGrounded)
        {
            jumpCount = maxJumpCount;
        }

        Move();
    }
    // Update is called once per frame
    void Update()
    {
        //Get inputs
        moveDirection = Input.GetAxis("Horizontal");


        if (moveDirection > 0 && !facingRight)
        {
            FlipCharacter();
        }
        else if (moveDirection < 0 && facingRight)
        {
            FlipCharacter();
        }

        //Move
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
    }

    private void Move()
    {
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);

        if (isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            jumpCount--;
        }
        isJumping = false;
    }

    private void ProcessInputs()
    {
        moveDirection = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            isJumping = true;
        }
    }
    private void FlipCharacter()
    {
        facingRight = !facingRight; // Inverse bool
        transform.Rotate(0f, 180f, 0f);
    }
}
