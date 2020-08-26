using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
	private void Start()
	{
		ClockScript.onHitClock += Invoke;
	}
	public void Invoke(float duration)
	{
        StartCoroutine(slowTime(duration));
	}

	IEnumerator slowTime(float duration)
	{
		Time.timeScale = 0.5f;
		yield return new WaitForSecondsRealtime(duration);
		Time.timeScale = 1.0f;
		yield break;
	}
}
