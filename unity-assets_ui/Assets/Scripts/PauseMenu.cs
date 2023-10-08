using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool pause = false;

    // Update is called once per frame
    void Update()
    {
        Pause();
    }

    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause == false)
            {
                pauseMenu.SetActive(true);
                pause = true;
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

            else if (pause == true)
            {
                Resume();
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        pause = false;
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        SceneManager.LoadScene(4);
    }
}
