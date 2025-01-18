using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePlay : MonoBehaviour
{
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void PlayGame()
    {
        Time.timeScale = 1;
    }
}
