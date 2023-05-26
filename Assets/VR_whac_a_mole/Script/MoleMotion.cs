using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleMotion : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0;
    private Vector3 moveDirection = Vector3.zero;
    
    // Update is called once per frame
    void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    public void MoveTo(Vector3 direction){ //외부에서 이동방향 주는 경우 사용하는 메서드
        moveDirection = direction;
    }
}
