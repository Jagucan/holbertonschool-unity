using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float min, sec, cent;
    private float currentTime = 0f;
    public Canvas winCanvas;
    public Text winTime;
    public GameObject mainCamera;

    void Update()
    {
        currentTime += Time.deltaTime;
        min = (int)(currentTime / 60f);
        sec = (int)(currentTime - min * 60f);
        cent = (int)((currentTime - (int)currentTime) * 100f);

        timerText.text = string.Format("{0:00}:{1:00}.{2:00}", min, sec, cent);
    }

    public void Win()
    {
        mainCamera.gameObject.GetComponent<CameraController>().enabled = false;
        winTime.text = timerText.text;
        timerText.enabled = false;
        winCanvas.gameObject.SetActive(true);
    }
}
