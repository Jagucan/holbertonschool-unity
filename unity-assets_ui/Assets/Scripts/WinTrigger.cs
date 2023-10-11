using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Timer timer;
    public GameObject winCanvas;
    public GameObject timerCanvas;
    private string timerTime;
    public TextMeshProUGUI winText;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Disable the Timer script, stop counting up an change the Text color and Size.
            winCanvas.SetActive(true);
            timer.enabled = false;
            timer.DisableTimer();
            timerTime = timer.timerText.text;
            //timer.timerText.color = Color.green;
            //timer.timerText.fontSize = 60;;
            winText.text = timerTime;
            timerCanvas.SetActive(false);
        }
    }
}
