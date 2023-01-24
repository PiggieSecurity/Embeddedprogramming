using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTeddy : MonoBehaviour
{
    public GameObject tospawnteddycube;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Teddy")
        {
            other.transform.position = new Vector3(tospawnteddycube.transform.position.x, tospawnteddycube.transform.position.y, tospawnteddycube.transform.position.z);
        }
    }
}
   
