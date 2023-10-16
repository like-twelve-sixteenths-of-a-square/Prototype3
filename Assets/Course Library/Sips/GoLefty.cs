using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoLefty : MonoBehaviour
{
    //Basic Movement Variables
    public float speed;
    private float wait = 5f;

    //To interact with the player
    private PlayerControl playerControlScript;

    private void Start()
    {
        //Simple timed destroy
        Invoke("Die", wait);

        //Properly contacts the player
       playerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    void Update()
    {
        //Contacts the game scrips, checks if the game is over, if not, move to the left
        if (playerControlScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    //The timed destroy.
    void Die()
    {
        Destroy(gameObject); 
    }
}
