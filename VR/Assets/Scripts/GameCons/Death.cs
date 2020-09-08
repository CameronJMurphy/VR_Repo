using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public static Action OnDeath;
    // Update is called once per frame
    void Update()
    {
        if(Player.instance.CurrentHealth() < 1)
        {
            OnDeath();
        }
    }
}
