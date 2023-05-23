using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleMotion : MonoBehaviour
{
    public float speed;
    float Up;
    float Down;
    // Start is called before the first frame update
    void Start()
    {
        Up = 0;
        Down = 2.26f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Up >= Down){
            transform.position = new Vector3(0, Down, 0);
            Down += Time.deltaTime * -speed * 1/60;
        }
        Up += Time.deltaTime * speed * 1/60;
        transform.position = new Vector3(0, Up, 0);
    }
}
