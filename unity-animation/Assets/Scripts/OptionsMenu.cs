using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Toggle toggleInvert;
    private bool isInverted;

    public void Awake()
    {
        if (PlayerPrefs.GetInt("Y", 0) == 0)
        {
            isInverted = false;
        }
        else
        {
            isInverted = true;
            toggleInvert.isOn = isInverted;
        }
    }

    public void Back()
    {
        PlayerPrefs.SetString("Prev", SceneManager.GetActiveScene().name);
        SceneManager.LoadSceneAsync(0);
    }

    public void Apply()
    {
        if (toggleInvert.isOn)
        {
            PlayerPrefs.SetInt("Y", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Y", 0);
        }

        SceneManager.LoadSceneAsync(PlayerPrefs.GetString("Prev", "MainMenu"), LoadSceneMode.Single);
    }

}
