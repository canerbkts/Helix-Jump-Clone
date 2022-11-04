using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanel;
    private void OnCollisionEnter(Collision collision)
    {
        GameOverFunc();
    }
    private void GameOverFunc()
    {
        Time.timeScale = 0;
        GameOverPanel.SetActive(true);
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
