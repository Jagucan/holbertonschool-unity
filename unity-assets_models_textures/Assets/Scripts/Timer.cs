using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float timerTime;
    //public bool isRunning = false;
    private int min, sec, cent;

    // Update is called once per frame
    void Update()
    {
        timerTime += Time.deltaTime;
        min = (int)(timerTime / 60f);
        sec = (int)(timerTime - min * 60f);
        cent = (int)((timerTime - (int)timerTime) * 100f);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", min, sec, cent);
    }
}
