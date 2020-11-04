using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb, enemyRb;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

    }

    // Update is called once per frame
    void Update()
    {
        //Check for key press/spacebar is pressed
        
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {   
            //jump code
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}   
