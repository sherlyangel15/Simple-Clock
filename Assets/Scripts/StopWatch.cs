using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] textArray;
    [SerializeField] Button button;
    [SerializeField] Sprite startSprite;
    [SerializeField] Sprite stopSprite;

    [SerializeField] float TimerCounter = 0f;
    [SerializeField] DateTime count;
    [SerializeField] bool isRunning;

    [SerializeField] string hour;
    [SerializeField] string min;
    [SerializeField] string sec;

    void Start()
    {
        ResetTimer();
        isRunning = false;
        button.image.sprite = startSprite;
    }

    void Update()
    {
        if (isRunning)
        {
            UpdateTimerDisplay();
        }
        DisplayCount();
    }

    void UpdateTimerDisplay()
    {
        TimerCounter += Time.deltaTime;
        if(TimerCounter >= 1f)
        {
            count = count.AddSeconds(1);
            TimerCounter = 0f;
        }
    }

    public void StartTimer()
    {
        if((button.image.sprite = startSprite) && (!isRunning))
        {
            isRunning = true;
            button.image.sprite = stopSprite;
        }
        else if((button.image.sprite = stopSprite) && (isRunning))
        {
            isRunning = false;
            button.image.sprite = startSprite;
        }

    }

    public void ResetTimer()
    {
        foreach(TextMeshProUGUI text in textArray)
        {
            count = DateTime.MinValue;
            count.AddSeconds(1);
        }
    }

    void DisplayCount()
    {
        hour = count.ToString("HH");
        min = count.ToString("mm");
        sec = count.ToString("ss");

        textArray[0].text = hour[0].ToString();
        textArray[1].text = hour[1].ToString();
        textArray[2].text = min[0].ToString();
        textArray[3].text = min[1].ToString();
        textArray[4].text = sec[0].ToString();
        textArray[5].text = sec[1].ToString();
    }
}
