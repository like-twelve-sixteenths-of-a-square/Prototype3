using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacle;
    public float startDelay;
    public float minRate;
    public float maxRate;
    private PlayerControl playerControlScript;

    private Vector3 spawnOffset = new Vector3(0, 5, 0);
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, Random.Range(minRate, maxRate));
        playerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    void SpawnObstacle() 
    {
        if (playerControlScript.gameOver == false)
        {
            int obstacleIndex = Random.Range(0, obstacle.Length);
            Instantiate(obstacle[obstacleIndex], transform.position+spawnOffset, transform.rotation);
        }
    }
}
