using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2f;
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
        FindObjectOfType<GameSession>().ResetGame();
    }
    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
        
    }

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Game over");
    }

    public void LoadQuide()
    {
        Application.Quit();
    }
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }
}
