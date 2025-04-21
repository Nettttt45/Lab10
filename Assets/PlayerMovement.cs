using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float move;
    Vector2 moveInput;

    public float Speed;
    public float JumpForce;
    public bool IsJumping;

    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb2d.AddForce(moveInput * Speed);

        if (Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(new Vector2(rb2d.velocity.x, JumpForce));
            Debug.Log("Jump!");
        }
    }
}

