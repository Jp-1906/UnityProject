using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void mulai()
    {
        SceneManager.LoadSceneAsync(2);
    }
    
    public void readyScene()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void backMenu()
    {
        SceneManager.LoadSceneAsync(0);

        Time.timeScale = 1f;
    }
}
