using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneManager : MonoBehaviour
{
    public void PlayGameButton()
    {
        SceneManager.LoadSceneAsync("Pong Game");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }
}
