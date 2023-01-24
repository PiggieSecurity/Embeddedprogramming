using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch_cheers : MonoBehaviour
{
    public string scene;
    private float waitTime = 400f;
    private float interval = 1f;
    private bool startCount;
    public AudioSource AudioSource;



    private void OnTriggerEnter(Collider other)
    {
        startCount = true;
        if (!AudioSource.isPlaying)
        {
            AudioSource.Play();
        }
    }
    private void Update()
    {
        if (startCount && waitTime > 0)
        {
            waitTime = waitTime - interval;
        }
        if (waitTime == 0f )
        {
            SceneManager.LoadScene(scene);
            
        }

    }
}
