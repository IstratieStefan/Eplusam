using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Rng : MonoBehaviour
{
    public TextMeshPro num;
    void Start()
    {
        string[] snippets = {"1", "2", "3","4","5","6","7","8","9","11","12","13","14","15","16","17","18","19","20"};
        var index = Random.Range(0, snippets.Length);
        num.text = snippets[index];
    }

    void Update()
    {

    }
}
