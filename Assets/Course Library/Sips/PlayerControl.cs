using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && Input.GetKey(KeyCode.LeftShift)) { playerRb.AddForce(Vector3.up * jumpForce * 2, ForceMode.Impulse); isOnGround = false; }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) { playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); isOnGround = false; }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
