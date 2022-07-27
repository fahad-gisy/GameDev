using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsMoving : MonoBehaviour
{
    // Start is called before the first frame update
    public float movingSpeed = 3f;
    public CharacterController _characterController;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float inputH = Input.GetAxis("Horizontal") * movingSpeed * Time.deltaTime; // getting A&D input >  X
       float inputV = Input.GetAxis("Vertical") * movingSpeed * Time.deltaTime; // getting W&S >  Z
       Vector3 movingForward = transform.right * inputH + transform.forward * inputV; // moving while facing and looking to the way we are moving to
       _characterController.Move(movingForward);
    }
}
