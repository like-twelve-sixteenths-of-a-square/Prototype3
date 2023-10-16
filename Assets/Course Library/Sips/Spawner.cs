using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Forms a list of potential obstacles to spawn.
    public GameObject[] obstacle;

    //Determines the delay between obstacles spawning
    public float startDelay;
    public float minRate;
    public float maxRate;

    //Readies this script to interact with the player's script.
    private PlayerControl playerControlScript;

    //An offset to ensure the obstacles spawned aren't in the floor
    private Vector3 spawnOffset = new Vector3(0, 5, 0);
    void Start()
    {
        //Prepares two things, the obstacles spawning in accordance to the previously enstated delays, and contacts the player's script
        InvokeRepeating("SpawnObstacle", startDelay, Random.Range(minRate, maxRate));
        playerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    void SpawnObstacle() 
    {
        //Takes the contact with the player's script, and spawns random obstacles from a list until the game is over
        if (playerControlScript.gameOver == false)
        {
            int obstacleIndex = Random.Range(0, obstacle.Length);
            Instantiate(obstacle[obstacleIndex], transform.position+spawnOffset, transform.rotation);
        }
    }
}
