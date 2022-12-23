using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject victoryUI;

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void victory()
    {
        victoryUI.SetActive(true);
    }

    // public void mainMenu()
    // {
    //     SceneManager.LoadScene("MainMenu")
    // }


}
