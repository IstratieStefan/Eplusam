using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNum : MonoBehaviour
{
    public GameObject num;
    void Start()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        int i = 4;
        while (i >= 0)
        {
            yield return new WaitForSeconds(4);
            float spawnY = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
            float spawnX = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;

            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            Instantiate(num, spawnPosition, Quaternion.identity);
            i--;
        }
    }

    void Update()
    {

    }
}
