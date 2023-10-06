using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGRepeat : MonoBehaviour
{
    private Vector3 StartPos;
    private float repeatWidth;

    void Start()
    {
        StartPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    void Update()
    {
        if (transform.position.x < StartPos.x - repeatWidth) { transform.position = StartPos; }
    }
}
