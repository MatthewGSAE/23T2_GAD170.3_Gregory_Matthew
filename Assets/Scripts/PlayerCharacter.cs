using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Pool;

public class PlayerCharacter : MonoBehaviour
{
    // movement variable
    private float movementSpeed = 12f;
    private float yawSpeed = 2.0f;
    private float pitchSpeed = 2.0f;
    private float yawAngle = 0.0f;
    private float pitchAngle = 0.0f;

    // controlling
    private CharacterController controller;
    private Vector3 velocity;

    // keeps you on the ground
    private float gravity = -20f;

    private float groundDistance = 0.4f;

    private bool isGrounded;

    private float jumpHeight = 2f;

    // death text box
    [SerializeField] private TextMeshPro textBox;

    public bool isAlive = true;

    private void Start()
    {
        if (controller == null)
        {
            controller = GetComponent<CharacterController>();
        }

        textBox.enabled = false;
    }

    private void Update()
    {
        if (isAlive)
        {
            // These lines let the script rotate the player based on the mouse moving
            yawAngle += yawSpeed * Input.GetAxis("Mouse X");
            pitchAngle -= pitchSpeed * Input.GetAxis("Mouse Y");

            // Get the Left/Right and Forward/Back values of the input being used (WASD, Joystick etc.)
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            // Let the player jump if they are on the ground and they press the jump button
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
            }

            // Rotate the player based off those mouse values we collected earlier
            transform.eulerAngles = new Vector3(0.0f, yawAngle, 0.0f);

            // This is stealing the data about the player being on the ground from the character controller
            isGrounded = controller.isGrounded;

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            // This fakes gravity!
            velocity.y += gravity * Time.deltaTime;

            // This takes the Left/Right and Forward/Back values to build a vector
            Vector3 move = transform.right * x + transform.forward * z;

            // Finally, it applies that vector it just made to the character
            controller.Move(move * movementSpeed * Time.deltaTime + velocity * Time.deltaTime);
        }
    }

   // private void OnCollisionEnter(Collision collision)
   // {
       // if (collision.gameObject.CompareTag("Ground"))
      //  {
            //do nothing
       // }
      //  else
       // {
         //   isAlive = false;

          //  textBox.enabled = true;

         //   if (Input.GetKeyDown(KeyCode.R))
          //  {
                //respawn player

              //  textBox.enabled = false;
         //   }
      //  }
   // }
}


