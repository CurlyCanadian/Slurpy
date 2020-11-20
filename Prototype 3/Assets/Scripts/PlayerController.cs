using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb, enemyRb;
    public float jumpForce = 10;
    public float gravityModifier =1;
    public bool isOnGround = true;
    public bool gameOver = false;
    
    private Animator PlayerAnim;

    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;
    public AudioSource PlayerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        PlayerAnim = GetComponent<Animator>();

        PlayerAudio = GetComponent<AudioSource>();
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
            PlayerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();

            PlayerAudio.PlayOneShot(jumpSound, 1.0f);
       
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
            isOnGround = false;
            PlayerAnim.SetBool("Death_b", true);
            PlayerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            PlayerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}   
