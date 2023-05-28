using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_test : MonoBehaviour
{
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
