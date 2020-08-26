using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    bool active = true;
    public static Action onHitBomb = delegate { };
    [Min(0)] public int damage;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hand" && active)
        {
            active = false;
            onHitBomb();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            Player.instance.TakeDamage(damage);
            active = false;
        }
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
