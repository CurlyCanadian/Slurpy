using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 50;
    private float turnSpeed = 80;
    //side controlles
    private float horizontalInput;
    //move forward
    private float verticalInput;
    //jump?
    private float jumpInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotates vehicle left and right based on horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);       
        
        // moves vehicle forward and back on VerticalInput
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime *speed * verticalInput);
        
        
        //jump
        //jumpInput = Input.GetAxis("Jump");
        //transform.Translate(Vector3.up * Time.deltaTime * speed * jumpInput);
    }
}
