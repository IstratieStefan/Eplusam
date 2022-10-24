using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    double movement = 3000;
    int step = 1;
    readonly Vector3[] directions = {new Vector3(0f, 0.1f, 0f), new Vector3(-0.1f, 0f, 0f), new Vector3(0f, -0.1f, 0f), new Vector3(0.1f, 0f, 0f) };

    void Update()
    {
        if (movement > 0)
        {
            movement -= 1;
            transform.position += directions[step];

        } else
        {
            movement = 3000;
            step++;
            step %= 4;
        }
        
    }
}
