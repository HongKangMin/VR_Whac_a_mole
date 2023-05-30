using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class delete : MonoBehaviour
{
    public GameObject hit;
    private void OnTriggerExit(Collider other)
    {
        Destroy(hit);
    }
}
