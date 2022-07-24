using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class force : MonoBehaviour
{
    public float moveForce; // force var
    public Rigidbody  playerRigidBody; // This RigidBody
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>(); // getting the RigidBody of THIS
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.UpArrow)){ // adding force on Y and X
             playerRigidBody.AddForce(new Vector3(0,moveForce,0),ForceMode.VelocityChange);
       }  

       if(Input.GetKey(KeyCode.DownArrow)){
             playerRigidBody.AddForce(new Vector3(0,-moveForce,0),ForceMode.VelocityChange);
       } 

       if(Input.GetKey(KeyCode.LeftArrow)){
             playerRigidBody.AddForce(new Vector3(-moveForce,0,0),ForceMode.VelocityChange);
       } 

       if(Input.GetKey(KeyCode.RightArrow)){
             playerRigidBody.AddForce(new Vector3(moveForce,0,0),ForceMode.VelocityChange);
       } 
    }
}
