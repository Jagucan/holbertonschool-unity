using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LevelSelect(int level)
    {
        SceneManager.LoadSceneAsync(level);
        Time.timeScale = 1;
    }
   
    public void Options()
    {
        PlayerPrefs.SetString("Prev", SceneManager.GetActiveScene().name);
        SceneManager.LoadSceneAsync(4);
    }
   
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited");
    }
}
