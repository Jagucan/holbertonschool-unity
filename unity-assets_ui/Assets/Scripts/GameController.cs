using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public GameObject newPlayer;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            newPlayer.SetActive(true);
            StartCoroutine(LoadScene(2f));
        }
    }
    public void RestartScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        RestartScene();
    }
}
