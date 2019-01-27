using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D player;
    public bool isJumping = false;
    private float xVelocity = 0;
    private float yVelocity = 0;
    private float maxSpeed = 10;
    private float direction = 1;

    public Camera mainCam;

    public GameObject bullet;
    public GameObject playerSprite;
    public Transform bulletSpawn;

    public GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isJumping = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            xVelocity += 1f;
            direction = 1;
            playerSprite.transform.localScale = new Vector2(1, 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            xVelocity -= 1f;
            direction = -1;
            playerSprite.transform.localScale = new Vector2(-1, 1);
        }
        else
        {
            xVelocity = 0;
        }

        if (Mathf.Abs(xVelocity) > maxSpeed)
        {
            xVelocity = maxSpeed * direction;
        }

        player.velocity = new Vector2(xVelocity, player.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space)&& isJumping == false)
        {
            isJumping = true;
            player.AddForce(Vector2.up * 5000);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Shooting();
        }
    }

    private void Shooting()
    {
        if (direction == 1)
        {
            GameObject temp = Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            temp.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.right * 3000);
        }

        else if (direction == -1)
        {
            GameObject temp = Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            temp.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.left * 3000);
        }
    }
}
