using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoinColloect : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform _transform; // transform for moving
    public AudioSource coinSound;
    [SerializeField] private float _rotateSpeed = 0.4f; // move speed
    void Start()
    {
        coinSound = GetComponent<AudioSource>(); // getting AS Cp
       _transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    private void Rotate(){
          _transform.Rotate(Vector3.left * _rotateSpeed); // Rotating Coins
    }

  
       private void OnTriggerEnter(Collider other) {
        if(other.gameObject.TryGetComponent<DojoFPController>(out var movingPlayer)){  // accses our player in this mothe >  so we can update coins got and deleting the coin
         movingPlayer.money++; // adding +1 whenever coin destroyed 
         coinSound.Play(); // playing it
         Debug.Log("Coins :  " + movingPlayer.money); 
         Destroy(gameObject,0.4f); // Destroyed!! coin
         
        }
        
    }
}
