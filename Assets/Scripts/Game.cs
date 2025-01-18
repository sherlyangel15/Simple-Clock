using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] textArray;
    [SerializeField] TextMeshProUGUI topText;
    GameObject winImage;
    TextMeshProUGUI buttonText;
    Color _greenColor = new Color(0.522f, 0.894f, 0.459f); // 85E475 in RGB
    Color _redColor = new Color(0.894f, 0.553f, 0.459f); // E48D75 in RGB

    DateTime SecondCount;
    [SerializeField] bool isCounting;
    float TimerCounter = 0f;

    string sec;
    string millisec;

    int seconds;
    int milliseconds;

    public bool testing;

    void Start()
    {
        buttonText = GameObject.FindWithTag("GameButton").GetComponentInChildren<TextMeshProUGUI>();
        winImage = GameObject.FindWithTag("WinImage");
        buttonText.text = "START";
        buttonText.color = _greenColor;
        isCounting = false;
        winImage.SetActive(false);
    }

    void Update()
    {
        if (isCounting)
        {
            UpdateTimerDisplay();
        }
        DisplaySecondCount();
    }
    public void StartButton()
    {
        if(buttonText.text == "START" && !isCounting)
        {
            isCounting = true;
            buttonText.text = "STOP";
            buttonText.color = _redColor;
            topText.text = "Think you can do it? Only one in a million succeed!";
            return;
        }
        if(buttonText.text == "STOP" && isCounting)
        {
            isCounting = false;
            if(textArray[2].text == "0" && textArray[3].text == "0")
            {
                if(textArray[0].text == "1" && textArray[1].text == "0")
                {
                    Winner();
                    topText.text = "You did it—fantastic! Up for another try?";
                }
            }
            else
            {
                topText.text = "It's alright, take another try!";
            }
        }
    }

    void DisplaySecondCount()
    {
        sec = SecondCount.ToString("ss");
        millisec = milliseconds.ToString();
        if(millisec.Length >= 2)
        {
            textArray[0].text = sec[0].ToString();
            textArray[1].text = sec[1].ToString();
            textArray[2].text = millisec[0].ToString();
            textArray[3].text = millisec[1].ToString();
        }
        if(testing)
        {
            textArray[0].text = "1";
            textArray[1].text = "0";
            textArray[2].text = "0";
            textArray[3].text = "0";
        }
    }

    void UpdateTimerDisplay()
    {
        TimerCounter += Time.deltaTime;

        seconds = Mathf.FloorToInt(TimerCounter); 
        milliseconds = Mathf.FloorToInt((TimerCounter - seconds) * 1000);

        if(TimerCounter >= 1f)
        {
            SecondCount = SecondCount.AddSeconds(1);
            TimerCounter = TimerCounter % 1f;
        }
    }

    void Winner()
    {
        Debug.Log("You Win!!");
        StartCoroutine(ShowAndHideImage());
    }

    IEnumerator ShowAndHideImage()
    {
        winImage.SetActive(true);
        yield return new WaitForSeconds(3f);
        winImage.SetActive(false);
    }
}
