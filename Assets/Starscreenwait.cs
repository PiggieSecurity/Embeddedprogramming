using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starscreenwait : MonoBehaviour
{
    private float Waitingtime = 500f;
    // Update is called once per frame
    void Update()
    {
        Waitingtime -= 1f;
        if(Waitingtime <= 0f)
        {
            SceneManager.LoadScene("Start");
        }
    }
}
