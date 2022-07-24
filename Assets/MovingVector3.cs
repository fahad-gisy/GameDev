using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingVector3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {          //corrent position + vector3.forward = moving ahead Z 
       transform.position += Vector3.forward*Time.deltaTime;  
    //             corrent position Rotate on Z * time  
        transform.Rotate(0,0,5.0f * Time.deltaTime);


    }
}
