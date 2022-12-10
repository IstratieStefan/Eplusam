using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;

    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }
    void Update()
    {

    }
}