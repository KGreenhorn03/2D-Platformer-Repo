using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb = null;
    public float speed = 0;
    public float jumpHeight = 0;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {

        isGrounded = true;

    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            isGrounded = false;

        }

    }
}
