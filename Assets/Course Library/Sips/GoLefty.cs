using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoLefty : MonoBehaviour
{
    public float speed;
    private float wait = 5f;
    private PlayerControl playerControlScript;

    private void Start()
    {
        Invoke("Die", wait);
       playerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    void Update()
    {
        if (playerControlScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    void Die()
    {
        Destroy(gameObject); 
    }
}
