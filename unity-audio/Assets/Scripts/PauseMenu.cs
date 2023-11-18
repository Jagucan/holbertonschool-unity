using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Canvas pauseMenu;
    public GameObject mainCamera;
    private Scene currentScene;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
            {
                Resume();
            }
    }

    public void Pause()
    {
        pauseMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
        mainCamera.gameObject.GetComponent<CameraController>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
  
    public void Resume()
    {
        Time.timeScale = 1;
        mainCamera.gameObject.GetComponent<CameraController>().enabled = true;
        pauseMenu.gameObject.SetActive(false);
    }

    public void Restart()
    {
        Resume();
        currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadSceneAsync(currentScene.buildIndex);
    }
 
    public void Options()
    {
        currentScene = SceneManager.GetActiveScene();
        PlayerPrefs.SetString("Prev", currentScene.name);
        Resume();
        SceneManager.LoadSceneAsync(4);
    }

    public void MainMenu()
    {
        Resume();
        SceneManager.LoadSceneAsync(0);
    }
}
