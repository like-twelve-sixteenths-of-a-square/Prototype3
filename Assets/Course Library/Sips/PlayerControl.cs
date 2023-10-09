using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;

    //This space exists only to prevent the massive line of variables from getting longer without a break
    private Animator animator;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && Input.GetKey(KeyCode.LeftShift) && !gameOver) { playerRb.AddForce(Vector3.up * jumpForce * 2, ForceMode.Impulse); isOnGround = false; animator.SetTrigger("Jump_trig"); }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) { playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); isOnGround = false; animator.SetTrigger("Jump_trig"); }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) { isOnGround = true; }
        else if (collision.gameObject.CompareTag("Obstacle")) { gameOver = true; Debug.Log("R.I.P. Bozo"); animator.SetBool("Death_b", true); animator.SetInteger("DeathType_int", 1); }
    }
}
