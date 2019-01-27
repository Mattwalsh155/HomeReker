using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour //----- MAKE A bullet TAG FOR THE BULLET-----//
{
    public GameObject[] wayPoints;
    private int currentWayPoint = 0;
    public Rigidbody enemy;
    private float speed = .1f;
    public GameObject bullet;
    public Transform bulletSpawn;

    // Use this for initialization
    void Start()
    {

    }

    private void OnEnable()
    {
        InvokeRepeating("Shooting", 3, 3);
    }

    private void OnDisable()
    {
        CancelInvoke("Shooting");
    }
    
    void Shooting()
    {
        GameObject temp = Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        temp.GetComponent<Rigidbody>().AddRelativeForce(Vector3.right * 500);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == wayPoints[currentWayPoint].transform.position.x)
        {
            if (currentWayPoint == 0)
            {
                currentWayPoint = 1;
                transform.Rotate(new Vector3(0, 180, 0));
            }
            else
            {
                currentWayPoint = 0;
                transform.Rotate(new Vector3(0, 180, 0));
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
