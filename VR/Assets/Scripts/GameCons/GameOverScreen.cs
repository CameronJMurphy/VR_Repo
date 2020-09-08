using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    GameController GC;
    bool isOn = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        Death.OnDeath += TurnOn;
        GC = FindObjectOfType<GameController>();
    }

    public void TurnOn()
	{
        gameObject.SetActive(true);
        Time.timeScale = 0;
        isOn = true;

    }

    public void TurnOff()
	{
        gameObject.SetActive(false);
        Time.timeScale = 1;
        isOn = false;
        Player.instance.Heal(Player.instance.maxHealth - Player.instance.CurrentHealth());
        GC.ResetGame();
    }

	private void Update()
	{
		if(isOn)
		{
            if (Input.GetButtonDown("Fire1"))
			{
                TurnOff();
			}
		}
	}
}
