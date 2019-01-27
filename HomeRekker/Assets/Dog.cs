using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour //----- MAKE AN bullet TAG SO THE ENEMY CAN DIE :)))))-----//
{
    public GameObject[] wayPoints;
    private int currentWayPoint = 0;
    public Rigidbody enemy;
    private float speed = .1f;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y == wayPoints[currentWayPoint].transform.position.y)
        {
            if (currentWayPoint == 0)
            {
                currentWayPoint = 1;
                //dogRigidbody.isKinematic = true;  
            }
            else
            {
                currentWayPoint = 0;
                //transform.Rotate(new Vector3(0, 180, 0));
                //dogRigidbody.isKinematic = true;
            }

        }
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, speed);
    }

    // Bullet collision for killing the enemy

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        // Level Spawn Locations and End Screen
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(this.gameObject);
        }

    }

    }
