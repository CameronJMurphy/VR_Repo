using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeTextColour : MonoBehaviour
{
	public TextMeshProUGUI text;
	public Color colour;

	private void Start()
	{
		GoldenApple.onEatGoldenApple += Invoke;
	}
	public void Invoke(float duration)
	{
		StartCoroutine(ChangeColour(duration));
	}

	IEnumerator ChangeColour(float duration)
	{
		Color previousColour = text.faceColor;
		text.faceColor = colour;
		yield return new WaitForSecondsRealtime(duration);
		text.faceColor = previousColour;
		yield break;
	}

}
