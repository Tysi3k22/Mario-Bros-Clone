using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int jumpForce = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("w"))
        {
            rb.linearVelocity = Vector3.up * jumpForce;
        }
    }
}
