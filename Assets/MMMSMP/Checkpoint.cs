using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject respawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
            if (collision.tag == "Checkpoint")
            {
                respawnPoint.transform.localPosition = this.transform.localPosition;
            }
       
    }
}
