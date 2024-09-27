using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public Transform[] waypoints;

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy = this.gameObject;

        if (waypoints.Length > 0)
        {
            enemy.transform.position = waypoints[0].position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        while (waypoints.Length > 0 / < 11)
        {
            enemy.transform.position += Vector3.MoveTowards(waypoints[]);
        }
    }

    //Sla Waypoints op in een Array:
    //Maak een script dat alle waypoints opslaat in een array.
    //Dit script verzamelt alle kinderen van het containerobject,
    //zodat de vijand deze punten één voor één kan bereiken.
}
