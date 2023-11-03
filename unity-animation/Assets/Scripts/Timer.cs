using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    private float minimumTime = 0f;
    private float currentTime;
    private bool timeState = false;
    public Text timerText;
    private int min, sec, cent;

    private void Start()
    {
        EnableTimer();
    }
    void Update()
    {
        if (timeState)
        {
            ChangeTimer();
        }
    }

    // Print the Time Current in the Screen.
    private void ChangeTimer()
    {
        currentTime += Time.deltaTime;
        min = (int)(currentTime / 60f);
        sec = (int)(currentTime - min * 60f);
        cent = (int)((currentTime - (int)currentTime) * 100f);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", min, sec, cent);
    }

    // 
    private void ChangeTimerState(bool state)
    {
        timeState = state;
    }

    // Enable the Timer and Set the counter on 0.
    public void EnableTimer()
    {
        currentTime = minimumTime;
        ChangeTimerState(true);
    }

    // Disable the Timer and stop the counter.
    public void DisableTimer()
    {
        ChangeTimerState(false);
    }

    public void Win()
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
