using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour
{

    public float playerSpeed = 10f;
    public  float rotationSpeed = 10;

    public int money = 0;
    private CharacterController characercontroller;
    // Start is called before the first frame update
    void Start()
    {
      characercontroller = GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
    Move();
    Rtotate();                
    }

    private void Move(){
         float inputV = Input.GetAxisRaw("Vertical") * playerSpeed; // getting input on  z
         Vector3 playerMovement = new Vector3(0,0,inputV) * Time.deltaTime; // setting it on NEW V3 to make it move
         playerMovement = transform.TransformDirection(playerMovement); //transform Direction to playerDirection
         characercontroller.Move(playerMovement); // moving by Move()>> how should character move

    }

    private void Rtotate(){
        float inputH = Input.GetAxisRaw("Horizontal") * playerSpeed; // getting input on X 
        Vector3 rotation = transform.rotation.eulerAngles; //v3 to rotate by Quaternion.eluerAngles
        rotation.y += inputH * Time.deltaTime * rotationSpeed; // getting Y pos + adding it to the X pos * time * speed
        transform.rotation = Quaternion.Euler(rotation); // the result


    }
}
