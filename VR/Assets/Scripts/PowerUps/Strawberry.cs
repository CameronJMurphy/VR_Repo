using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Strawberry : MonoBehaviour
{
    bool active = true;
    public static Action onHitStrawberry = delegate {};

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hand" && active)
        {
            active = false;
            onHitStrawberry();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            Player.instance.Heal(1);
            active = false;
        }
    }
}
