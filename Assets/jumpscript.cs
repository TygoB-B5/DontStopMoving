using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscript : MonoBehaviour
{
    private bool onGround = true;
    public Rigidbody player;
    private float jumpForce = 120;
    private float runSpeed = 80;
    public Animator animator;


    void Update()
    {
        Movement();
        Jump();
    }

    void Movement()
    {
        animator.SetBool("isIdle", false);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        transform.Translate(Vector3.right * runSpeed * Time.deltaTime);
    }

    void Jump()
    {
        if (Input.GetKeyDown("space"))
        {
            if (onGround)
            {
                player.velocity = new Vector3(0, jumpForce, 0);
                onGround = false;
                animator.SetBool("isJumping", true);
            }
        }
    }


    void OnCollisionEnter(Collision col)
    {
        TestJump(col);
    }

    void TestJump(Collision col)
    {
        if (col.gameObject.CompareTag("jump"))
        {
            onGround = true;
            animator.SetBool("isJumping", false);
        }
    }
}
