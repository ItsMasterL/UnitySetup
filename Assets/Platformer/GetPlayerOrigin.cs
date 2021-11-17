using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerOrigin : MonoBehaviour
{

    private Vector3 playerOrigin;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        playerOrigin = player.transform.position;
        transform.localPosition = playerOrigin;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
