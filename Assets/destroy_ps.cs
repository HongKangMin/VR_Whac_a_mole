using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_ps : MonoBehaviour
{
    [SerializeField]
    private GameObject ps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(ps);
    }
}
