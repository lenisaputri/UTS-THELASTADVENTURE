using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool facingRight = true;
    public Rigidbody2D rb;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && facingRight)
        {
            rb.velocity = new Vector2(-5, rb.velocity.y);
            Flip();

        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && !facingRight)
        {
            rb.velocity = new Vector2(5, rb.velocity.y);
            Flip();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, 10f);
        }
    }

    void Flip()
    {
        // Switch the way the player is labelled as facing.
        facingRight = !facingRight;
        //Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
