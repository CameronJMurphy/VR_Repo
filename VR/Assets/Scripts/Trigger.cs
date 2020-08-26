using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public UnityEvent OnTrigger;
	public UnityEvent OnCollision;


	private void OnTriggerEnter(Collider other)
	{
		OnTrigger.Invoke();
	}

	private void OnCollisionEnter(Collision collision)
	{
		OnCollision.Invoke();
	}
}
