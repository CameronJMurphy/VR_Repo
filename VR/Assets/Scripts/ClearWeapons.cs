using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearWeapons : MonoBehaviour
{
    List<Spawner> spawners;
    // Start is called before the first frame update
    void Start()
    {
        spawners = new List<Spawner>(FindObjectsOfType<Spawner>());
        Bomb.onHitBomb += Invoke;
    }

    public void Invoke()
    {
        foreach (var spawner in spawners)
        {
            foreach (var weapon in spawner.GetComponentsInChildren<Weapon>())
            {
                Destroy(weapon.gameObject);
            }
        }
    }
}
