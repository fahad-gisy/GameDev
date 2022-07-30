using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{  
    // Start is called before the first frame update
    public Animator animator;
    void Start()
    {
         animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {       //walking anim forward on and off
        if(Input.GetKey(KeyCode.W)){
             animator.SetBool("IsWalking",true);

        }else if(Input.GetKeyUp(KeyCode.W)){
             animator.SetBool("IsWalking",false);
        }
          //walking anim backward on and off
         if(Input.GetKey(KeyCode.S)){
             animator.SetBool("IsWalkingBack",true);

        }else if(Input.GetKeyUp(KeyCode.S)){
             animator.SetBool("IsWalkingBack",false);
        }

         if(Input.GetKey(KeyCode.LeftShift)){
             animator.SetBool("IsRunning",true);

        }else if(Input.GetKeyUp(KeyCode.LeftShift)){
             animator.SetBool("IsRunning",false);
        }
       
    //    if(Input.GetKey(KeyCode.A)){
    //          animator.SetBool("IsWalkingSideL",true);

    //     }else if(Input.GetKeyUp(KeyCode.A)){
    //          animator.SetBool("IsWalkingSideL",false);
    //     }

        
    }
}
