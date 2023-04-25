using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private float moveDirection;
    
   
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        //get inputs 
        ProcessInputs();
        // animate
        Animate();

    }
    private void FixedUpdate()
    {
        
        //move
        Move();
    }

    private void Animate()
    {
        if (moveDirection > 0 && !facingRight)
        {
            FlipCharacter();
        }
        else if (moveDirection < 0 && facingRight)
        {
            FlipCharacter();
        }
    }

    private void Move()
    {
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);

        
    }

    private void ProcessInputs()
    {
        moveDirection = Input.GetAxis("Horizontal"); //scale of -1 > 1

      
    }

    private void FlipCharacter()
    {
        facingRight = !facingRight;

        transform.Rotate(0f, 180f, 0f);
    }
}
