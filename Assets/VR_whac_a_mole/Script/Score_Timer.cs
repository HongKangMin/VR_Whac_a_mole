using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Timer : MonoBehaviour
{
    public TMP_Text Score;
    public TMP_Text Last_Score;
    public TMP_Text Best_Score;
    public TMP_Text Timer;

    public static bool Game_Start = false;
    public static int Whac_Score = 0;
    public int Whac_Best_Score = 0;
    public int Whac_Last_Score = 0;
    private float Whac_timer = 0;

    public GameObject UI_Panel;
    public GameObject Start_Panel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Whac_timer < 60f && Game_Start)
        {
            Score.text = Whac_Score.ToString();

            Whac_timer += Time.deltaTime;
            Timer.text = "Time: " + Whac_timer.ToString("F1") + "s";
        }
        else if (Whac_timer > 60f && Game_Start)
        {
            Game_Start = false;
            UI_Panel.SetActive(true);
            Whac_Last_Score = Whac_Score;
            if(Whac_Best_Score < Whac_Last_Score)
            {
                Whac_Best_Score = Whac_Last_Score;
            }
            Last_Score.text = Whac_Last_Score.ToString();
            Best_Score.text = Whac_Best_Score.ToString();

            Whac_Score = 0;
            Whac_timer = 0;
        }
    }

    public void Game_Start_Button_On()
    {
        Start_Panel.SetActive(false);
        Game_Start = true;
    }
    public void Game_Resume()
    {
        UI_Panel.SetActive(false);
        Game_Start = true;
    }
    public void Game_Retry()
    {
        UI_Panel.SetActive(false);
        Game_Start = true;
    }
}
