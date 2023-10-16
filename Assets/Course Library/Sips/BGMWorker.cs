using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Here's a simple one.
public class BGMWorker : MonoBehaviour
{
    //Prepares Player Control Script
    private PlayerControl playerControlScript;

    //Gets the audio source
    public AudioSource audioSource;

    void Start()
    {
        //Prepares that bad boy
        playerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    void Update()
    {
        if (playerControlScript.gameOver == true)
        {
            audioSource.Stop();
        }
    }
}
