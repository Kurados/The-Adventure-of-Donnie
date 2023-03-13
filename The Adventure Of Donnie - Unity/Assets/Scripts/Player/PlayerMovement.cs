using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class PlayerMovement : MonoBehaviour
{

    private float horizontal;
    private float direction;
    public float speed = 6f;
    public float jumpSpeed = 8f;
    private Rigidbody2D rb;
    private bool ifFacingRight = true;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;

    //Animation
    public Animator animator;
    public DialogueManager dialogue;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        movement();

        if (direction != 0 && DialogueManager.isActive == false)
        {
            //Debug.Log("naghihiro");
            animator.SetBool("run", true);
        }
        else
        {
            //Debug.Log("dai naghihiro");
            animator.SetBool("run", false);
            
        }


        //Flip
        if (direction > 0f && !ifFacingRight)
        {
            Flip();
        }
        else if (direction < 0f && ifFacingRight)
        {
            Flip();
        }

        //debug sa pag dialouge nag hihiro pa
        if(DialogueManager.isActive == true)
        {
            stop();
        }
     
        //print(rb.velocity);
    }

    /*public void Move(InputAction.CallbackContext context)
    {
       
        horizontal = context.ReadValue<Vector2>().x;
    }

    public void Jump(InputAction.CallbackContext context)
    {
     

        if (context.performed && isGrounded())
        {
            animator.SetBool("jump", true);
            soundManager.PlaySound("jumping01");
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }

    }*/


    void movement()
    {
        if (DialogueManager.isActive == true)
            return;
        // Player movement
        direction = Input.GetAxis("Horizontal");
        if (direction > 0f)
        {
            rb.velocity = new Vector2(direction * speed, rb.velocity.y);
        }
        else if (direction < 0f)
        {
            rb.velocity = new Vector2(direction * speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        // Player jump
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            animator.SetBool("jump", true);
            soundManager.PlaySound("jumping01");
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }

    public void stop()
    {
        rb.velocity = new Vector2(0f, rb.velocity.y);
    }

    //Ground checker
    private bool isGrounded()
    {
        
        return Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

    // Flip function
    private void Flip()
    {
        ifFacingRight = !ifFacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            animator.SetBool("jump", false);
        }
    }
}
