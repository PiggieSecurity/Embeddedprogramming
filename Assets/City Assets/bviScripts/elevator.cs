using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class elevator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject button;
    private GameObject presser;
    private AudioSource buttonSound;
    public AudioSource elevator_sound;
    private float waitTime = 500f;
    private bool isPressed;
    public string scene;
    public CinemachineDollyCart[] elevator_movement;

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
            buttonSound.Play();
            isPressed = true;
            foreach (CinemachineDollyCart c in elevator_movement)
            {
                c.m_Speed = 5;
            }
            elevator_sound.Play();
        }
        
    }
    private void Update()
    {
        if (isPressed)
        {
            waitTime = waitTime - 1f;
        }
        if (waitTime <= 0f)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
