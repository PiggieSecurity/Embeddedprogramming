using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource source;
    public GameObject player;
    private bool move = false;

    private void Update()
    {
        if(Input.GetAxis("Vertical") < 0.01f && Input.GetAxis("Horizontal") < 0.01f && Input.GetAxis("Vertical") > -0.01f && Input.GetAxis("Horizontal") > -0.01f){
            Debug.Log("player moving");
            move = true;
            if (move)
            {
                source.Play();
            }

        }
        else if (Input.GetAxis("Vertical") == 0 || Input.GetAxis("Horizontal") == 0)
        {
            move = false;
            if (!move)
            {
                source.Stop();
            }
        }
    }

}
