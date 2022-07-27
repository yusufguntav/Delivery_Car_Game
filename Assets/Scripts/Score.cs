using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    [SerializeField] TMP_Text Text;
    [SerializeField] TMP_Text Timer;
    [SerializeField] TMP_Text FinishScreenScore;

    public int score = 0;
    public int minute = 2;
    string minute_str;
    string second_str;
    [HideInInspector] public float second = 0f;
    [SerializeField] GameObject FinishScreen;

    void Update()
    {
        Text.text = "Box: "+ score;
        
        // Timer
        if(minute.ToString().Length == 1){
            minute_str = "0"+minute;
        }else{
            minute_str = minute.ToString();
        }
        if (second >= 60)
        {
            int secondd = Mathf.FloorToInt(second)%60;
            minute += (Mathf.FloorToInt(second)-secondd)/60;
            second = secondd;
            
        }
        if(second < 0 && minute!=0){
            minute--;
            second = 60;
        }
        if (second < 10 && second >= 0)
        {
            second_str = "0"+ Mathf.FloorToInt(second).ToString();
        }else
        {
            second_str = Mathf.FloorToInt(second).ToString();
        }
        
        if (minute > 0 || second > 1)
        {
            second -= Time.deltaTime;
        }else{
            FinishScreenScore.text = "Score: "+ score;
            FinishScreen.SetActive(true);
            FindObjectOfType<CarMovement>().enabled = false;
        }
        

        Timer.text = "Timer: "+minute_str+":"+second_str;
    }
}
