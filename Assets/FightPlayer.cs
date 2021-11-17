using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightPlayer : MonoBehaviour
{

    public GameObject target;
    public float speed;
    public float health = 10;
    public float bulletSpeed = 800;
    public float bulletSpeed2 = 850;
    public float timer = 1;
    private Rigidbody2D rb2;
    public float thrustScale;

    public GameObject Bullet;
    public GameObject FirePoint;
    public GameObject FirePoint2;
    public GameObject FirePoint3;
    public GameObject Self;


    private void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //point at player
        Vector3 vectorToTarget = target.transform.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - 90;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);



    }

    private void FixedUpdate()
    {
        //fire at player
        timer -= Time.deltaTime;
        float distancetoplayer = Vector3.Distance(target.transform.position, transform.position);
        Debug.Log(distancetoplayer);

        if (timer <= 0 && distancetoplayer <= 17)
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
            timer = 1;
        }
        //move to player
        if (distancetoplayer >= 7 && distancetoplayer <= 25)
        {
            float thrust = Time.deltaTime * thrustScale;
            rb2.AddForce(transform.up * thrust);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            health -= 1;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
