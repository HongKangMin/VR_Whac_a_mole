using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer_show : MonoBehaviour
{

    public GameObject hammer1;
    public GameObject hammer2;
    public GameObject hammer3;
    public GameObject hammer4;
    public GameObject hammer5;
    public GameObject hammer6;
    public GameObject hammer7;
    // Start is called before the first frame update
    void Start()
    {
        hammer1.SetActive(false);
        hammer2.SetActive(false);
        hammer3.SetActive(false);
        hammer4.SetActive(false);
        hammer5.SetActive(false);
        hammer6.SetActive(false);
        hammer7.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Score_Timer.Whac_Score > 30)
        {
            hammer1.SetActive (true);
        }
        if (Score_Timer.Whac_Score > 40)
        {
            hammer2.SetActive(true);
        }
        if (Score_Timer.Whac_Score > 50)
        {
            hammer3.SetActive(true);
        }
        if (Score_Timer.Whac_Score > 60)
        {
            hammer4.SetActive(true);
        }
        if (Score_Timer.Whac_Score > 70)
        {
            hammer5.SetActive(true);
        }
        if (Score_Timer.Whac_Score > 80)
        {
            hammer6.SetActive(true);
        }
        if (Score_Timer.Whac_Score > 90)
        {
            hammer7.SetActive(true);
        }
    }
}
