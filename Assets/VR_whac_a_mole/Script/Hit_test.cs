using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Hit_test : MonoBehaviour
{

    public GameObject hit;

    public bool CoolDown = false;

    private Collider mole;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Mole" && Score_Timer.Game_Start)
        {
            StartCoroutine(ShowEffect());
            if (!CoolDown)
            {
                CoolDown = true;
                Score_Timer.Whac_Score += 1;
                Invoke("Hit_Check", 1f);
            }
        }
    }   
    private void OnTriggerExit(Collider mole)
    {
        Debug.Log("충돌 끝");
    }
    private void OnTriggerStay(Collider mole)
    {
        Debug.Log("충돌 중");
        
    }

    IEnumerator ShowEffect()
    {
        hit.SetActive(true);
        yield return new WaitForSecondsRealtime(1.0f);
        Debug.Log("충돌 시작");
        hit.SetActive(false);
    }

    private void Hit_Check()
    {
        CoolDown = false;
    }
}
