using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Strawberry : MonoBehaviour
{
    bool active = true;
    public static Action onHitStrawberry = delegate {};
    MeshRenderer renderer;
	private void Start()
	{

    }
	private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hand" && active)
        {
            renderer = GetComponent<MeshRenderer>();
            active = false;
            onHitStrawberry();
            renderer.material.SetColor("_Color", new Vector4(0,1,0,1));
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


    private void OnBecameInvisible()
	{
        Destroy(gameObject);
	}
}
