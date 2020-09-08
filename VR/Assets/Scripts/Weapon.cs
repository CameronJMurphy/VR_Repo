using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    bool active = true;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hand" && active)
        {
            active = false;
            GetComponent<BoxCollider>().enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(active)
        {
            Player.instance.TakeDamage(damage);
            active = false;
            GetComponent<BoxCollider>().enabled = false;
        }
    }

	private void OnBecameInvisible()
	{
        Destroy(gameObject);
	}
}
