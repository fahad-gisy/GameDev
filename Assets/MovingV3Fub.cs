using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingV3Fub : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        //another way to transform position here we can input where we want to move
          this.transform.position = this.transform.position + new Vector3(0.01f,0,0 * Time.deltaTime);
    }
}
