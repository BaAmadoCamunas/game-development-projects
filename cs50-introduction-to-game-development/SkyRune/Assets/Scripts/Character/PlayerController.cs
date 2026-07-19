using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    #region Variables

    [Header("Movement Variables")]
    public float speed;
    public float rotationSpeed;
    private Vector3 velocity;

    // Character variables
    [Header("Character Variables")]
    private float horizontalInput;
    private float verticalInput;
    private float magnitude;
    private Vector3 movementDirection;
    private CharacterController characterController;


    // Jump variables
    [Header("Jump Variables")]
    [SerializeField] private float jumpSpeed;
    private float ySpeed;

    // Camera variables
    [Header("Camera Variables")]
    [SerializeField] private Transform cameraTransform;

    // Slope variables
    [Header("Slope Variables")]
    private bool isSliding;
    private Vector3 slopeSlideVelocity;

    // Animation variables
    [Header("Animator Variables")]
    private Animator playerAnimatorController;

    #endregion



    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        playerAnimatorController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get inputs
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement's direction and rotation
        movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;

        movementDirection = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles.y, Vector3.up) * movementDirection;
        movementDirection.Normalize();

        playerAnimatorController.SetFloat("PlayerWalkVelocity", movementDirection.magnitude * speed);

        ySpeed += Physics.gravity.y * Time.deltaTime;

        SlopeSlideVelocity();

        if (slopeSlideVelocity == Vector3.zero)
        {
            isSliding = false;
        }

        // Calculate the character's jump
        PlayerJump();


        velocity = movementDirection * magnitude;
        velocity.y = ySpeed;

        characterController.Move(velocity * Time.deltaTime);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }

    // Method for calculate the character's jump
    private void PlayerJump()
    {
        // If the character is grounded, can jump
        if (characterController.isGrounded)
        {
            if (slopeSlideVelocity != Vector3.zero)
            {
                isSliding = true;
            }

            if (isSliding == false)
            {
                ySpeed = -0.5f;
            }

            if (isSliding)
            {
                Vector3 velocity = slopeSlideVelocity;
                velocity.y = ySpeed;

                characterController.Move(velocity * Time.deltaTime);
            }


            if (Input.GetButtonDown("Jump"))
            {
                ySpeed = jumpSpeed;
                playerAnimatorController.SetTrigger("PlayerJump");
            }
        }
        // If not, is falling down
        else
        {
            playerAnimatorController.SetFloat("PlayerVerticalVelocity", characterController.velocity.y);
        }

        playerAnimatorController.SetBool("IsGrounded", characterController.isGrounded);
    }



    // Method for detect if the character is on a slope and that slides him down
    private void SlopeSlideVelocity()
    {
        // Simulate the angle with the ground, and if it greater than the playerController's slope limit, makes that the character goes down the slope
        if (Physics.Raycast(transform.position + Vector3.up, Vector3.down, out RaycastHit hitInfo, 5))
        {
            float angle = Vector3.Angle(hitInfo.normal, Vector3.up);

            if (angle >= characterController.slopeLimit)
            {
                slopeSlideVelocity = Vector3.ProjectOnPlane(new Vector3(0, ySpeed, 0), hitInfo.normal);
                return;
            }
        }

        if (isSliding)
        {
            slopeSlideVelocity -= slopeSlideVelocity * Time.deltaTime * 3;

            if (slopeSlideVelocity.magnitude > 1)
            {
                return;
            }
        }
        slopeSlideVelocity = Vector3.zero;

    }


    private void OnAnimatorMove()
    {

    }
}
