using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    [SerializeField] private Timer timer;

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Enable the Timer script and start counting up
            if (!timer.enabled)
            {
                timer.enabled = true;
                timer.DisableTimer();
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
