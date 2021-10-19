using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float maxSpeed = 6f;
    float horizontalSpeed = 0f;
    float verticalSpeed = 0f;
    Animator animator;
    Rigidbody2D body;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update(){

        SetAnimation();

        if (Input.GetKey(KeyCode.LeftArrow)) {
            body.velocity = new Vector2(-maxSpeed, body.velocity.y);
            MovePlayer(horizontalSpeed, verticalSpeed);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            body.velocity = new Vector2(maxSpeed, body.velocity.y);
            MovePlayer(horizontalSpeed, verticalSpeed);
        }
        else {
            body.velocity = new Vector2(0, body.velocity.y);
            MovePlayer(horizontalSpeed, verticalSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            body.velocity = new Vector2(body.velocity.x, -maxSpeed);
            MovePlayer(horizontalSpeed, verticalSpeed);
        }
        else if (Input.GetKey(KeyCode.UpArrow)) {
            body.velocity = new Vector2(body.velocity.x, maxSpeed);
            MovePlayer(horizontalSpeed, verticalSpeed);
        }
        else {
            body.velocity = new Vector2(body.velocity.x, 0);
            MovePlayer(horizontalSpeed, verticalSpeed);
        }
    }

    private void SetAnimation()
    { 
        if(body.velocity.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (body.velocity.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else{ }

        animator.SetFloat("Velocity", body.velocity.sqrMagnitude);
    }

    void MovePlayer(float horizontalSpeed, float verticalSpeed)
    {
        body.AddForce(new Vector2(horizontalSpeed, verticalSpeed));
    }
}