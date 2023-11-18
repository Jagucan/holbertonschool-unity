using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public GameObject mainCamera;
    private int currentLevel;


    public void MainMenu()
    {
        mainCamera.gameObject.GetComponent<CameraController>().enabled = true;
        SceneManager.LoadSceneAsync(0);
    }

    public void Next()
    {
        mainCamera.gameObject.GetComponent<CameraController>().enabled = true;
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        
        if (currentLevel != 3)
        {
            SceneManager.LoadSceneAsync(currentLevel + 1);
            Time.timeScale = 1;
        }
        else
        {
            SceneManager.LoadSceneAsync(0);
        }   
    }
}
