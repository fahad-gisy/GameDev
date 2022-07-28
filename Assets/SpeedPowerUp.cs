using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
     private DojoFPController playerScript; // player's controller script
     private bool isFaster = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject && isFaster == false)
        {
        
        isFaster = true; // We are using this bool to make sure that we do not trigger this object multiple times so that our speed does not increase out of control.
            playerScript = other.GetComponent<DojoFPController>(); // getting our player controller so we can change his speed
            playerScript.playerSpeed += 3; 
            playerScript.PlayerRunSpeed += 3;
            
            Debug.Log("POWER UP !! YOU ARE FASTER");
        }
    }
}
