using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_test : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌 시작");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("충돌 끝");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌 중");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("트리거 충돌 시작");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("트리거 충돌 끝");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("트리거 충돌 중");
    }
}
