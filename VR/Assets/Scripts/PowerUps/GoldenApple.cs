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
            GetComponent<BoxCollider>().enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            active = false;
            onEatGoldenApple(invulnerableDuration);
            GetComponent<BoxCollider>().enabled = false;
        }
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
