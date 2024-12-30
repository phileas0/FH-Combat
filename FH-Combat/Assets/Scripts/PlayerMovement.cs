using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private float horizontal;
    private bool isMoving;
    private CharacterController controller;
    private Animator animator;

    // Start is called before the first execution of Update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get horizontal input
        horizontal = Input.GetAxis("Horizontal") * moveSpeed;

        // Create the movement vector along the Z-axis
        Vector3 move = new Vector3(0, 0, horizontal);

        // Move the player
        controller.Move(move * Time.deltaTime);

        // Rotate the player if moving
        if (horizontal > 0)
        {
            // Face forward
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (horizontal < 0)
        {
            // Face backward
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        // Check if either A or D is pressed and update isMoving
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        // Update animation states
        animator.SetBool("isMoving", isMoving);
    }
}
