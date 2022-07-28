using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DojoFPController : MonoBehaviour
{
    // 3rd person cam
    [SerializeField] private Transform cameraTarget; // tranform our cam
    private Camera mainCamera; //varieble to set our main cam in
    [SerializeField] private bool invertMouse = false; // veriable for invert up and down : X rotation
    private float verticalRotationLimit; // limiting x rotation 
    [SerializeField] private float mouseSensivitiy; 
    [SerializeField] private float lookUpClamp;
    [SerializeField] private float lookDownClamp;
    //movement
    public float playerSpeed;
    public float PlayerRunSpeed;
    public int money = 0;
    private CharacterController characterController;
    private Vector3 movement;

    void Start()
    {    
        Cursor.lockState = CursorLockMode.Locked;
        characterController = GetComponent<CharacterController>(); // getting the characterController in our player
        mainCamera = Camera.main; // setting the main cam in this variable
    }
    private void Update()
    {
        Vector2 mouseInput = new(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y") * mouseSensivitiy);

        float yRotation = transform.rotation.eulerAngles.y + mouseInput.x; // getting player's Y rot + mouseIput on X
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, yRotation, transform.rotation.eulerAngles.z); // X the same , Y rotating , Z the Same > so we just rotating the game opject on Y

        float invert = (!invertMouse) ? -1f : 1f; // invert our rotation?
        verticalRotationLimit += (mouseInput.y * invert); /*   
        This is the mouse invert preference multiplier and,
         is basically what controls how our camera's vertical rotation will switch between inverted and not inverted.
         Depending on whether our invertMouse bool is true or false, our code will multiply this new invert float by 1/-1,
         flipping the direction at which our camera goes when looking up or down. 
            */
        verticalRotationLimit = Mathf.Clamp(verticalRotationLimit,lookDownClamp, lookUpClamp); // make sure that's our cam can't rotate more that we wanted to

        cameraTarget.rotation = Quaternion.Euler(verticalRotationLimit, cameraTarget.eulerAngles.y, cameraTarget.eulerAngles.z);
        /* X Rotation = verticalRotationLimit, which is tied to vertical mouse inputs and limits.
           Y Rotation = leave it as is (NOT 0 because setting this to zero would keep it locked to that rotation value).
           Z Rotation = leave it as is.  */

           Vector3 moveForward = transform.forward * Input.GetAxisRaw("Vertical"); // W & S input * our player's forward facing
           Vector3 moveRight = transform.right * Input.GetAxisRaw("Horizontal"); // A & D input * our player's right facing
           //rsing up the player speed whenever leftShfit is pressed
           float correntSpeed = (Input.GetKey(KeyCode.LeftShift)) ? PlayerRunSpeed : playerSpeed; 

        //Normalized means our Vector3's directions will remain the same. Forward will surely stay forward for the player, same with left and right
           movement = (moveForward + moveRight).normalized * correntSpeed; // take our facing input and insert it in vector 3
           characterController.Move(movement * Time.deltaTime); // moving our chacarter based on the movement me made

    }

    // Update is called once per frame
    void LateUpdate()
    {
        mainCamera.transform.position = cameraTarget.position; // setting the main cam into the target cam pos > bring the main camera to target
        mainCamera.transform.rotation = cameraTarget.rotation;  // setting the main cam into the target cam rot > bring the main camera to target
    }
}
