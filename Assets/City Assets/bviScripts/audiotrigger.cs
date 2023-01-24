using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiotrigger : MonoBehaviour
{
    public AudioSource AudioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (!AudioSource.isPlaying)
        {
            AudioSource.Play();
        }
    }
}
