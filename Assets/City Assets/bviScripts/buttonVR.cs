using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class buttonVR : MonoBehaviour
{
    public GameObject button;
    private GameObject presser;
    private AudioSource buttonSound;
    public AudioSource barrier_sound;
    private bool isPressed;
    public GameObject barrier;
    // Start is called before the first frame update
    void Start()
    {
        buttonSound = GetComponent<AudioSource>();
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            presser = other.gameObject;
            barrier.transform.Rotate(270,0,0);
            buttonSound.Play();
            barrier_sound.Play();
            isPressed = true;
        }
    }
}
