using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinColloect : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform _transform; // transform for moving
    [SerializeField] private float _rotateSpeed = 0.4f; // move speed
    void Start()
    {
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
        if(other.gameObject.TryGetComponent<MovingPlayer>(out var movingPlayer)){  // accses our player in this mothe >  so we can update coins got and deleting the coin
         movingPlayer.money++;
         Debug.Log("Coins :  " + movingPlayer.money);
         Destroy(gameObject); // Destroyed!! coin
        }
        
    }
}
