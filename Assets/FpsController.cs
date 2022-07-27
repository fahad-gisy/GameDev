using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsController : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 10f; // mouse speed
     public Transform playerBody; // player transform
     private float xRotation = 0f; 
    void Start()
    {
         Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
       float inputX = Input.GetAxis("Mouse X") * speed * Time.deltaTime; // getting mouse input on X
       float inputY = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;  // getting mouse input on Y
      xRotation-= inputY; // x - y  = moving up and down based on X rotation
      transform.localRotation = Quaternion.Euler(xRotation,0f,0f); // rotation happing here > rotate up and down
      xRotation = Mathf.Clamp(xRotation , -90,50); // make sure camera can't look behind or under the player
      playerBody.Rotate(Vector3.up * inputX); // rotating the camera&the player on X Right & Left

       
       
    }
}
