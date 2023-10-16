using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMOove : MonoBehaviour
{
    public float speed;
    private void Start()
    {
        Invoke("delete", 10);
    }
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void delete()
    {
        Destroy(gameObject);
    }
}
