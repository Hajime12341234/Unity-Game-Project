using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

*/

/*

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}

*/


/*

using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f * 2;
    public float jumpHeight = 3f;
    public float rotationSpeed = 100f; // Adjust rotation speed as needed

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    void Update()
    {
        // Check if the player is grounded
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        // Reset vertical velocity if grounded
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // Get movement input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 move = transform.right * x + transform.forward * z;

        // Move the player
        controller.Move(move * speed * Time.deltaTime);

        // Jumping
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        // Apply gravity
        velocity.y += gravity * Time.deltaTime;

        // Move the player based on velocity
        controller.Move(velocity * Time.deltaTime);


    }
}


*/


public class Player_controller : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 30f;
    public float gravity = -9.81f * 2;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public float mouseSensitivity = 600f;
    float xRotation = 0f;
    float yRotation = 0f;

    void Start()
    {
        // Lock cursor to center of screen and hide it
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Check if the player is grounded
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        // Reset vertical velocity if grounded
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // Get movement input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 moveDirection = new Vector3(x, 0f, z).normalized;

        // Move the player
        controller.Move(moveDirection * speed * Time.deltaTime);

        // Jumping
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        // Apply gravity
        velocity.y += gravity * Time.deltaTime;

        // Move the player based on velocity
        controller.Move(velocity * Time.deltaTime);


        /*

        // Rotation with mouse or touchpad
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        yRotation += mouseX;

        // Apply rotation to the player object (for first-person perspective)
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

        */




        /*


        // Rotation with keys
        if (Input.GetKey(KeyCode.I))
        {
            xRotation -= mouseSensitivity * Time.deltaTime;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        }
        else if (Input.GetKey(KeyCode.O))
        {
            xRotation += mouseSensitivity * Time.deltaTime;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        }

        if (Input.GetKey(KeyCode.J))
        {
            yRotation -= mouseSensitivity * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.K))
        {
            yRotation += mouseSensitivity * Time.deltaTime;
        }

        // Apply rotation to the player object (for first-person perspective)
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

        */


    }
}
