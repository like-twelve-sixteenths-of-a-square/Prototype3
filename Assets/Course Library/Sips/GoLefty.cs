using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoLefty : MonoBehaviour
{
    public float speed;
    private float wait = 5f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        Invoke("Die", wait);
    }

    void Die()
    {
        Destroy(gameObject); 
    }
}
