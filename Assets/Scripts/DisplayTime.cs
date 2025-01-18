using System;
using TMPro;
using UnityEngine;

public class DisplayTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] textArray;
    [SerializeField] DateTime currentTime;
    [SerializeField] DateTime Time;
    [SerializeField] string sec;
    [SerializeField] string min;
    [SerializeField] string hour;

    [SerializeField] TextMeshProUGUI meridiemText;
    [SerializeField] string meridiem;
    void Update()
    {
        Time = DateTime.Now;

        hour = Time.ToString("hh");
        min = Time.ToString("mm");
        sec = Time.ToString("ss");

        meridiem = Time.ToString("tt");
        meridiemText.text = meridiem;

        DisplayValue();
    }

    void DisplayValue()
    {
        textArray[0].text = hour[0].ToString();
        textArray[1].text = hour[1].ToString();
        textArray[2].text = min[0].ToString();
        textArray[3].text = min[1].ToString();
        textArray[4].text = sec[0].ToString();
        textArray[5].text = sec[1].ToString();
    }

}
