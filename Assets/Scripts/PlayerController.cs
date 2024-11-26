using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    public float turnSpeed = 90;
    public float speed = 20;
    public float horizontalInput ;
    public float forwardInput ;


    // Update is called once per frame
    void Update()
    {
    horizontalInput = Input.GetAxis("Horizontal");
     forwardInput = Input.GetAxis("Vertical");
     // Move the vehicle forward based on user input 
     transform.Translate ( Vector3.forward * Time.deltaTime * speed * forwardInput);
     // Rotates the car based on horizontal input
     transform.Rotate(Vector3.up  * Time.deltaTime * turnSpeed * horizontalInput);
    
    }

}
