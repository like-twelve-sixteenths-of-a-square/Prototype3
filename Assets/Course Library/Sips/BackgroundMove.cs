using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    private PlayerControl playerControlScript;

    private void Start()
    {
        playerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    void Update()
    {
        if (playerControlScript.gameOver == false)
        {
            transform.Translate(Vector3.left * 15 * Time.deltaTime);
        }
    }
}
