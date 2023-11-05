using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public GameObject custCamera;
    public GameObject playerAnimation;
    public GameObject player;
    public GameObject mainCamera;
    public GameObject timerCanvas;
    
    private void Update()
    {
        StartCoroutine(IntroController());
    }

    IEnumerator IntroController()
    {
        yield return new WaitForSeconds(10f);
        player.SetActive(true);
        mainCamera.SetActive(true);
        timerCanvas.SetActive(true);
        Destroy(playerAnimation, 0.1f);
        Destroy(custCamera, 0.1f);
    }
}
