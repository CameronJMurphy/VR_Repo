using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawberrySpawner : MonoBehaviour
{
    public GameObject strawberry;
    float timer = 0;
    public float timerMax;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timerMax)
        {
            Instantiate(strawberry, transform);
            timer = 0;
        }
    }
}
