using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour
{
    bool active = true;
    public static Action<float> onHitClock = delegate { };
    [Min(0)] public float slowTimeDuration;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hand" && active)
        {
            active = false;
            onHitClock(slowTimeDuration);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            active = false;
        }
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
