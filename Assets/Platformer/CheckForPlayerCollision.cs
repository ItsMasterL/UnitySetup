using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForPlayerCollision : MonoBehaviour
{
    public GameObject spawnpoint;
    public GameObject mainplayer;
    private Rigidbody2D rb2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            rb2 = mainplayer.GetComponent<Rigidbody2D>();
            rb2.velocity = new Vector2(0, 0);
            mainplayer.transform.localPosition = spawnpoint.transform.localPosition;
        }
    }

}
