using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    private TimerTrigger timerTrigger;
    public GameObject WinFlag;

    void Start()
    {
        timerTrigger = GetComponent<TimerTrigger>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WinFlag") && timerTrigger != null)
        {
            //timerTrigger.isRunning = false;
        }
    }
}
