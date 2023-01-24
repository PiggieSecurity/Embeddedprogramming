using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class StartWalking : MonoBehaviour
{
    private bool walking = false;
    private float waitTime = 100f;
    private float interval = 1f;
    private bool startCount;
    public CinemachineDollyCart walker;
    [SerializeField] private Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        startCount = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("isWalking",walker.m_Speed);
        if (startCount && waitTime > 0)
        {
            waitTime -= interval;
        }
        if (waitTime == 0f && !walking)
        {
            walking = true;
            walker.m_Speed = 0.3f;
        }
    }
}
