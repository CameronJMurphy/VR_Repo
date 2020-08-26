using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    #region Variables

    public GameObject obj;
    float timer = 0;
    [SerializeField] private float timerMax;
    [SerializeField][Min(1)] private float minTimer;

	#endregion

	#region Methods
	private void Start()
	{
		if(minTimer > timerMax)
		{
            Debug.LogError(gameObject.name + "- Spawner script: Min timer is larger than timerMax");
		}
	}
	// Update is called once per frame
	void Update()
    {
        timer += Time.deltaTime;
        if(timer > timerMax)
        {
           Instantiate(obj, transform);
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
	#endregion
}
