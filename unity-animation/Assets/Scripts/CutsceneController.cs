using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    Animator playerAnimation;
    public GameObject mainCamera;
    public GameObject player;
    public GameObject timerCanvas;
    public GameObject custCamera;
    
    void Awake()
    {
        playerAnimation = GetComponent<Animator>();
    }

    public void transition()
    {
        mainCamera.SetActive(true);
        timerCanvas.SetActive(true);
        player.gameObject.GetComponent<PlayerController>().enabled = true;
        custCamera.SetActive(false);
    }
}
