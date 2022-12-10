using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumMovement : MonoBehaviour
{

    Rigidbody2D body;

    public float runSpeed = 10.0f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        body.velocity = new Vector2(runSpeed, 0);
    }
}
