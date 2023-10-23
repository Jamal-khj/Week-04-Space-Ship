using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject youWinScreen;
    private bool isPaused = false;

    public PlayerHealth player1Health;
    public PlayerHealth player2Health;

    // Start is called before the first frame update
    void Start()
    {
        pauseScreen.SetActive(false);
        youWinScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        PauseScreen();
        GameOverScreen();
    }

    public void PauseScreen()
    {
        if (pauseScreen != null)
        {
            if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
            {
                Time.timeScale = 0;
                pauseScreen.SetActive(true);
                isPaused = true;

            }

            else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
            {

                Time.timeScale = 1;
                pauseScreen.SetActive(false);
                isPaused = false;
            }
        }
    }

    public void GameWonScreen()
    {
        Time.timeScale = 0;
        youWinScreen.SetActive(true);
    }

    public void GameOverScreen()
    {
        if (player1Health.player1Dead == true && player2Health.player2Dead == true)
        {
            //Debug.Log("they dead");
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);
        }
    }
    public void StartGame()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Main Game");
    }

    public void QuitGame()
    {
        Debug.Log("Game quit");
        Application.Quit();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
