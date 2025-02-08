using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class GodzillaMovement : MonoBehaviour
{

    public float godzilla_xSpeed;
    public float godzilla_xSprint;
    public float godzilla_ySpeed;
    public float godzilla_ySprint;
   
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public Rigidbody2D rb;
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");


        Vector2 direction = new Vector2(xInput, yInput).normalized;

        float xSpeed;
        float ySpeed;

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            xSpeed = godzilla_xSprint;
            ySpeed = godzilla_ySprint;
        }
        else
        {
            xSpeed = godzilla_xSpeed;
            ySpeed = godzilla_ySpeed;
        }
       
        Vector2 velocity = new Vector2(direction.x * xSpeed, direction.y * ySpeed);

        rb.linearVelocity = velocity;

        // Play Attack animation when the Space key is pressed
        // trigger parameter
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("Attack");
        }

        // Play Kick animation when the Right Mouse Button is clicked
        if (Input.GetButtonDown("Fire2"))
        {
            animator.SetTrigger("Kick");
        }

        // Play isWalking animation when walking (or running) 
        // bool parameter
        if (xInput != 0 || yInput != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }


        //change of animations direction
        if (xInput != 0)
        {
            Vector3 localScale = transform.localScale;
            localScale.x = Mathf.Abs(localScale.x) * Mathf.Sign(xInput);
            transform.localScale = localScale;


            foreach (Transform child in transform)
            {
                child.transform.localScale = localScale;
            }
        }
        
    }
}