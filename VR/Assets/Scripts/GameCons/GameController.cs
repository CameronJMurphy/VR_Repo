using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float timer;
    [SerializeField] private float difficultyIncreaseTime;
    [SerializeField] private float reduceTimerBy;
    List<SwordSpawner> spawners;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        spawners = new List<SwordSpawner>(FindObjectsOfType<SwordSpawner>());
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer > difficultyIncreaseTime)
		{
            timer = 0;
            foreach(var spawner in spawners)
			{
                spawner.ReduceTimerMax(reduceTimerBy);           
			}
		}
    }
}
