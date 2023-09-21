using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public Timer timer;
    public GameObject timerController;
    private bool timerStarted = false;

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && !timerStarted)
        {
            // Enable the Timer script and start counting up
            if (!timer.enabled)
            {
                timer.enabled = true;
                timerStarted = true;
            }
        }
    }
    /*
    private void Awake()
    {
        // Prevent the Timer GameObject from being destroyed on scene reset
        DontDestroyOnLoad(timer.gameObject);

    }
    */
}
