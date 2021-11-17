using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetWorld : MonoBehaviour
{
    public GameObject Player;
    public float resetCountdown = 3;

    // Update is called once per frame
    void Update()
    {
        if (Player == null)
        {
            resetCountdown -= Time.deltaTime;
            if (resetCountdown <= 0)
            {
                Debug.Log("Swich scene!");
                SceneManager.LoadScene("StageTwo");
            }
        }
    }
}
