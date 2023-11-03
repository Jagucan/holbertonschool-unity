using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    private float actualLevel;
    private float nextLevel;
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Next()
    {
        actualLevel = SceneManager.GetActiveScene().buildIndex;
        
        if (actualLevel == 1)
        {
            SceneManager.LoadScene(2);
        }
        else if (actualLevel == 2)
        {
            SceneManager.LoadScene(3);
        }
        else if (actualLevel == 3)
        {
            SceneManager.LoadScene(0);
        }
    }
}
