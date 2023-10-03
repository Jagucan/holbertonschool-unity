using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] private Timer timer;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Disable the Timer script, stop counting up an change the Text color and Size.
            timer.enabled = false;
            timer.DisableTimer();
            timer.timerText.color = Color.green;
            timer.timerText.fontSize = 60;
        }
    }
}
