using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenApple : MonoBehaviour
{

    bool active = true;
    public static Action<float> onEatGoldenApple = delegate { };
    [Min(0)]public float invulnerableDuration;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hand" && active)
        {
            active = false;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            active = false;
            onEatGoldenApple(invulnerableDuration);
        }
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
