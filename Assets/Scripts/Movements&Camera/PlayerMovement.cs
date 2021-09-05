using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float runSpeed = 5f;
    public Rigidbody2D rb;
    public Vector2 movement;
    public Animator animator;
    public bool isRunning = false;
    
    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        
    }
    
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            rb.MovePosition(rb.position + movement * runSpeed * Time.fixedDeltaTime);
            isRunning = true;

        }
        else
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
            isRunning = false;
        }
    }
    
    
    
}
