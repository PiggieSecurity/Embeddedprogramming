using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopBridge : MonoBehaviour
{
    public CinemachineDollyCart cart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cart.m_Position < 5)
        {
            cart.m_Speed = 0;
        }
    }
}
