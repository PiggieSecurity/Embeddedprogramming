
using System.Runtime.CompilerServices;
using UnityEngine;

public class raisebarrier : MonoBehaviour
{
    public GameObject barrier;
    private float waitTime = 2500f;
    private float interval = 1f;
    private bool up = false;
    private bool startCount;

 

    private void OnTriggerEnter(Collider other)
    {
        startCount = true;
    }
    private void Update()
    {
        if (startCount && waitTime > 0)
        {
            waitTime = waitTime - interval;
        }
        if (waitTime == 0f && up == false && barrier != null)
        {
            barrier.transform.Rotate(270, 0, 0);
            up = true;
        }
    }
}
