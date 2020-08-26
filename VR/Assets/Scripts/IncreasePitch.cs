using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasePitch : MonoBehaviour
{
  
    public GameObject target;
    private Vector3 startPosition;
    private Vector3 ourPosition;
    private Vector3 targetsPosition;
    private float distance;
    private float distanceTraveled;
    private float traveledPercentage;

    // Start is called before the first frame update
    void Start()
    {
        ourPosition = transform.position;
        startPosition = ourPosition;
        targetsPosition = target.transform.position;
        distance = DistanceBetween(startPosition, targetsPosition);
    }

    // Update is called once per frame
    void Update()
    {
        ourPosition = transform.position;
        distanceTraveled = DistanceBetween(ourPosition, startPosition);
        traveledPercentage = distanceTraveled / distance;
        ModifyObjectPitch(gameObject);
    }

    private float DistanceBetween(Vector3 pos1, Vector3 pos2)
    {
        return Vector3.Distance(pos1, pos2);
    }

    private void ModifyObjectPitch(GameObject obj)
    {
        AudioSource audioSource = obj.GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.pitch = easeInExpo(traveledPercentage);
        }
    }

    float easeInExpo(float t)
    {
        return Mathf.Pow(2, (10 * t - 9));
    }
}
