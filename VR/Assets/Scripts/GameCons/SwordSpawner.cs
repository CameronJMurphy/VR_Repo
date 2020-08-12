using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSpawner : MonoBehaviour
{
    public GameObject sword;
    List<GameObject> swords;
    float timer = 0;
    [SerializeField] private float timerMax;
    [SerializeField] private float minTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timerMax)
        {
           Instantiate(sword, transform);
           timer = 0;
        }
    }

    public void ReduceTimerMax(float reduction)
	{
        timerMax -= reduction;
        if(timerMax < minTimer)
		{
            timerMax = minTimer;
		}
	}
}
