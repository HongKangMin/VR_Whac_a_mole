using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_test : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹 ����");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("�浹 ��");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("�浹 ��");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ʈ���� �浹 ����");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Ʈ���� �浹 ��");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Ʈ���� �浹 ��");
    }
}
