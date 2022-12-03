using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnNum : MonoBehaviour
{
    public GameObject number;
    public Transform num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(num.position);
        if (screenPos.x < 0)
            Destroy(this.number);

    }
}
