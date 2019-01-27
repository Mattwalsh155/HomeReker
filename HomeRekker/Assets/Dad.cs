using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dad : MonoBehaviour
{

    public GameObject beer;
    public Transform beerSpawn;

    // Start is called before the first frame update
    void Start()
    {
        // MOVE ELSEWHERE AND ADD TIMER!
        // CHANGE SPEED because I'm too lazy to test at 60fps
        GameObject temp = Instantiate(beer, beerSpawn.transform.position, beerSpawn.transform.rotation);
        temp.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.right * 3000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
