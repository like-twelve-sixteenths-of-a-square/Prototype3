using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Control Variables
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;

    //Particle Variables
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    //Audio Varibles
    private AudioSource playerAudio;
    public AudioClip crashSound;
    public AudioClip jumpSound;
    public AudioClip bigJumpSound;

    //Animator Variable(s)
    private Animator animator;

    void Start()
    {
        //Get those sweet sweet components.
        playerRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        //Big Jump For Big Boxes
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && Input.GetKey(KeyCode.LeftShift) && !gameOver) 
        { 
            playerAudio.PlayOneShot(bigJumpSound); 
            dirtParticle.Stop(); 
            playerRb.AddForce(Vector3.up * jumpForce * 2, ForceMode.Impulse); 
            isOnGround = false; 
            animator.SetTrigger("Jump_trig"); 
        }
        //Normal Jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) 
        { 
            playerAudio.PlayOneShot(jumpSound); 
            dirtParticle.Stop(); 
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
            isOnGround = false; 
            animator.SetTrigger("Jump_trig"); 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Are you on the ground?
        if (collision.gameObject.CompareTag("Ground")) 
        { 
            isOnGround = true; 
            dirtParticle.Play(); 
        }
        //Did you touch an obstacle? Yes? Lose.
        else if (collision.gameObject.CompareTag("Obstacle")) 
        { 
            playerAudio.PlayOneShot(crashSound); 
            explosionParticle.Play(); 
            dirtParticle.Stop(); 
            gameOver = true; 
            Debug.Log("R.I.P. Bozo"); 
            animator.SetBool("Death_b", true); 
            animator.SetInteger("DeathType_int", 1);
        }
    }
}
