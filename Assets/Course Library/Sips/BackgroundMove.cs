using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Huh, turns out this script has a use too, might as well leave notes on it.
public class BackgroundMove : MonoBehaviour
{
    //Prepares to contact the player's control script
    private PlayerControl playerControlScript;

    private void Start()
    {
        //Contacts the player's control script.
        playerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    void Update()
    {
        //If the game hasn't ended accoridng to the player's control script, keep moving to the left.
        if (playerControlScript.gameOver == false)
        {
            transform.Translate(Vector3.left * 15 * Time.deltaTime);
        }
    }
}
