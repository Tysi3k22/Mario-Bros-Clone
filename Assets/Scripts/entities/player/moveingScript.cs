using UnityEngine;

public class moveingScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 15f;
    private float horizontal;
    private float speed = 5f;
    private bool isfacingRight = true;
    public Camera cam;

    public Transform groundCheck;
    public LayerMask groundLayer;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (isGrounded() && Input.GetButtonDown("Jump"))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        if (Input.GetButtonUp("Jump") && rb.linearVelocity.y > 0f)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }

        flip();

        cam.transform.position = new Vector3(transform.position.x + 2, cam.transform.position.y, transform.position.z - 10);
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void flip()
    {
        if (isfacingRight && horizontal < 0f || horizontal > 0f && !isfacingRight)
        {
            isfacingRight = !isfacingRight;
            Vector3 localScale = transform.localScale;

            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
