﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        explosion.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            explosion.gameObject.transform.parent = null;
            explosion.gameObject.SetActive(true);

            Destroy(this.gameObject);
        }
    }
}
