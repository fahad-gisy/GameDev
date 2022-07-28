using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    // Start is called before the first frame update
[SerializeField] private float speed;
[SerializeField] private Vector3 startPoint;

[SerializeField] private Vector3 endPoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    
         transform.localPosition = Vector3.Lerp(startPoint,endPoint,Mathf.PingPong(Time.time * speed, 1));
         /*
         Interpolates between the points a and b by the interpolant 
         t. The parameter t is clamped to the range [0, 1]. 
         This is most commonly used to find a point some fraction of the way along a line between two endpoints 
         (e.g. to move an object gradually between those points).   
         */
    }
}
