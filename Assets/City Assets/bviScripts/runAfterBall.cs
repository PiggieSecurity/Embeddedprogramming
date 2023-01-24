using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class runAfterBall : MonoBehaviour
{
    // Start is called before the first frame update
    private bool start;
    public CinemachineDollyCart Kid1;
    public CinemachineDollyCart Kid2;
    [SerializeField] private Animator animatorKid1;
    [SerializeField] private Animator animatorKid2;

    private void OnTriggerEnter(Collider other)
    {
        start = true;
        if (other.tag == "Ball")
        {
            Debug.Log("hit trigger");
            Destroy(other);
        }
    }

    // Update is called once per frame
    void Update()
    {
        animatorKid1.SetFloat("IsRunning", Kid1.m_Speed);
        if (start)
        {
            Kid1.m_Speed = 2f;
        }
        animatorKid2.SetFloat("IsRunning", Kid2.m_Speed);
        if (start)
        {
            Kid2.m_Speed = 2f;
        }
    }
}
