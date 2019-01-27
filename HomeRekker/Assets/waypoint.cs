using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint : MonoBehaviour
{
    public GameObject[] wayPoints;
    private int currentWayPoint = 0;
    private float speed = .1f;
    public Rigidbody Waypoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == wayPoints[currentWayPoint].transform.position.x) // Index out of range here???
        {
         
            if (currentWayPoint == 0)
            {
                currentWayPoint = 1;
            }
            else
            {
                currentWayPoint = 0;
            }

        }
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, speed);
    }
}