using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
 

    public float rotateScale;
    public float thrustScale;
    private Rigidbody2D rb2;
    public GameObject Bullet;
    public GameObject FirePoint;
    public GameObject FirePoint2;
    public GameObject FirePoint3;
    public float bulletSpeed;
    public float bulletSpeed2;
    public GameObject Self;
    public int health = 10;
    public GameObject HealthMask;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float rotation = Time.deltaTime * rotateScale * Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, 0, -rotation));

        float thrust = Time.deltaTime * thrustScale * Input.GetAxis("Vertical");
        rb2.AddForce(transform.up * thrust);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Self.transform.rotation);
            GameObject b2 = Instantiate(Bullet, FirePoint2.transform.position, Self.transform.rotation);
            GameObject b3 = Instantiate(Bullet, FirePoint3.transform.position, Self.transform.rotation);
            Rigidbody2D rb2b = b.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2b2 = b2.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2b3 = b3.GetComponent<Rigidbody2D>();
            rb2b.AddForce(transform.up * bulletSpeed);
            rb2b2.AddForce(transform.up * bulletSpeed);
            rb2b3.AddForce(transform.up * bulletSpeed2);
            Destroy(b, 4);
            Destroy(b2, 4);
            Destroy(b3, 4);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyBullet")
        {
            health -= 1;
            HealthMask.GetComponent<PlayerHealth>().MoveMask(health, 10);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
