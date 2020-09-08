using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Strawberry : MonoBehaviour
{
    bool active = true;
    public static Action onHitStrawberry = delegate {};
    MeshRenderer renderer;
    ParticleSystem particleSystem;

	private void Start()
	{
        particleSystem = GetComponent<ParticleSystem>();
    }
	private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hand" && active)
        {
            renderer = GetComponent<MeshRenderer>();
            active = false;
            renderer.material.SetColor("_Color", new Vector4(0,1,0,1));
            particleSystem.Play();
            GetComponent<BoxCollider>().enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            Player.instance.Heal(1);
            active = false;
            GetComponent<BoxCollider>().enabled = false;
        }
    }


    private void OnBecameInvisible()
	{
        StartCoroutine(DestroyThis());
    }

    IEnumerator DestroyThis()
	{
        yield return new WaitForSeconds(particleSystem.duration);
        Destroy(gameObject);
        yield break;
    }

}
