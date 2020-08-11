using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strawberry : MonoBehaviour
{
    bool active = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (CompareTag("Hand"))
        {
            active = false;
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
