using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWalking : MonoBehaviour
{
    public CinemachineDollyCart walker;

    private void OnTriggerEnter(Collider other)
    {
        walker.m_Speed = 0f;
    }
}
