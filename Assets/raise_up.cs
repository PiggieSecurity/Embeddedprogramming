using Cinemachine;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raise_up : MonoBehaviour
{
    public GameObject bridge;
    public CinemachineDollyCart cart;
    public CinemachineDollyCart ship;
    public GameObject barrier;
    public GameObject barrier2;
    private bool barrierStatus = true;
    public GameObject Player;
    private bool reached_top = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = transform;
            if (barrierStatus)
            {
                barrier.transform.Rotate(90, 0, 0);
                barrier2.transform.Rotate(90, 0, 0);
                barrierStatus = false;
            }
            cart.m_Speed = 0.5f;
            ship.m_Speed = 3f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }

    void Update()
    {
        if (!reached_top && cart.m_Position >= 25)
        {
            cart.m_Speed = 0;
            reached_top = true;
        }
        if (reached_top && ship.m_Position >= 305)
        {
            cart.m_Speed = -0.5f;
        }
        if (reached_top && cart.m_Position <= 5)
        {
            cart.m_Speed = 0;
            reached_top=false;
            if (!barrierStatus)
            {
                barrier.transform.Rotate(270, 0, 0);
                barrier2.transform.Rotate(270, 0, 0);
            }
        }
    }
}
