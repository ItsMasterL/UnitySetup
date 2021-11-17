using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;
    public int topb;
    public int bottomb;
    public int leftb;
    public int rightb;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        if(this.tag == "MMMSMP")
        {
        
                transform.position = new Vector3(0,transform.position.y,transform.position.z);
                if (transform.position.y <= 0)
            {
                transform.position = new Vector3(0, 0, transform.position.z);
            } else if (transform.position.y >= 115)
            {
                transform.position = new Vector3(0, 115, transform.position.z);
            }
        }
    }
}
