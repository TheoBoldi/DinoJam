using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDeplacement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");

        //Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(movement.x > 0)
        {
            gameObject.transform.localScale = new Vector3(5, 5, 5);
        }
        if(movement.x < 0)
        {
            gameObject.transform.localScale = new Vector3(-5, 5, 5);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
