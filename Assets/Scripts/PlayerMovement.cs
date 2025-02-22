using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement vars")]
    [SerializeField] private float jumpForce;
    [SerializeField] private float speed;
    [SerializeField] private bool isGrounded = false; 

    [Header("Settings")]
    [SerializeField] private Animator animator; 
    [SerializeField] private SpriteRenderer playerRotation;
    [SerializeField] private float jumpOffSet;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private Transform groundColliderTransform;
    [SerializeField] private LayerMask groundMask;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerRotation = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundColliderTransform.position, jumpOffSet, groundMask );
    }

    public void Move(float direction, bool isJumpButtonPress)
    {
        if(isJumpButtonPress)
            Jump();
        
        if(Mathf.Abs(direction) > 0.01f)
        {
            PlayerRotation(direction);
            HorizontalMovement(direction);
            animator.SetBool("isRunning",true);
        }
        else
        {
            animator.SetBool("isRunning",false);
        }
    }

    private void Jump()
    {
        if(isGrounded)
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void HorizontalMovement(float direction)
    {
        if(isGrounded)
            rb.velocity = new Vector2(curve.Evaluate(direction), rb.velocity.y);
    }

    private void PlayerRotation(float direction)
    {
        if(direction > 0)
        {
            playerRotation.flipX = false;
        }
        else if(direction < 0)
        {
            playerRotation.flipX = true;
        }
    }
}
