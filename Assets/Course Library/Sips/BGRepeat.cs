using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGRepeat : MonoBehaviour
{
    //Positioning Variables
    private Vector3 StartPos;
    private float repeatWidth;

    void Start()
    {
        //Finds the variables and prepares them.
        StartPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    void Update()
    {
        //Produces a clean(ish) background looping effect.
        if (transform.position.x < StartPos.x - repeatWidth) { transform.position = StartPos; }
    }
}
