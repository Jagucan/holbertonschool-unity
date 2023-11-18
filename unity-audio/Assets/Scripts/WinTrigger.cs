using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    private bool playerWon = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && playerWon == false)
        {
            playerWon = true;
            other.gameObject.GetComponent<Timer>().Win();
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
