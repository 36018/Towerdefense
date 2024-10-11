using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Waypoints : MonoBehaviour
{
    public Transform[] waypoints;
    private Vector3 targetposition = Vector3.zero;
    [SerializeField]
    private int waypointIndex = 0;
    public GameObject enemy;
    [SerializeField]
    private float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        enemy = this.gameObject;
        targetposition = waypoints[0].position;
        /*if (waypoints.Length > 0)
        {
            enemy.transform.position = waypoints[0].position;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        /*while (waypoints.Length > 0 / < 11)
        {
            enemy.transform.position += Vector3.MoveTowards(waypoints[]);
        }
        */

        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].position, step);

        if (Vector3.Distance(transform.position, waypoints[waypointIndex].position) < .1f && waypointIndex < waypoints.Length - 1)
        {
            waypointIndex++;
        }
    }

    //Sla Waypoints op in een Array:
    //Maak een script dat alle waypoints opslaat in een array.
    //Dit script verzamelt alle kinderen van het containerobject,
    //zodat de vijand deze punten één voor één kan bereiken.
}
