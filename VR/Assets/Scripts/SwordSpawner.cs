using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSpawner : MonoBehaviour
{
    public GameObject sword;
    List<GameObject> swords;
    float timer = 0;
    public float timerMax;
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
}
