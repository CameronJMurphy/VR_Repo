using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayHealth : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health:  " + Player.instance.CurrentHealth().ToString();
    }
}
