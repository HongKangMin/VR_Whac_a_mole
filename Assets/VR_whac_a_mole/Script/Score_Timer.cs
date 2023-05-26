using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Timer : MonoBehaviour
{
    public TMP_Text Score;
    public TMP_Text Timer;

    private int Whac_Score = 0;
    private float Whac_timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Whac_timer += Time.deltaTime;
        Timer.text = "Time: " + Whac_timer.ToString("F1") + "s";
    }
}
