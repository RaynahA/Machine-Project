using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    [SerializeField]

    float jumpStrength = 5.0f;

    float movementSpeed = 5.0f;

    float moveX;

    [SerializeField]
    bool isGrounded, canJump;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void PlayerControls()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canJump = true;
        }

        moveX = Input.GetAxis("Horizontal");
    }

    void Jump()
    {

        if (!isGrounded)
        {
            return;//if not grounded, this function is done     
        }

        Debug.Log("Jump");
        rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        Debug.Log(collision.gameObject.name, collision.gameObject);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX * movementSpeed, rb.velocity.y);

        if (canJump)
        {
            canJump = false;
            Jump();
        }
    }
    // Update is called once per frame
    void Update()
    {
        PlayerControls();
    }
}
