using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        //movement = 1 or -1 depending on the input,
        //Input.getAxisRaw is by default ASDW, ArrowKeys or controller input.

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    // FixedUpdate is called set amount of times per second (I think it's 50)
    private void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        Debug.Log(movement);
        //position + movement takes care of moveing the player, * movespeed takes care of what speed the player is moving,
        //* Time.fixedDeltaTime takes care of a constant movementspeed 

    }
}
