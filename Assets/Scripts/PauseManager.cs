using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    //Victory Screens
    public GameObject playerOneUI;
    public GameObject playerTwoUI;
    public GameObject playerThreeUI;
    public GameObject playerFourUI;

    public GameObject scoreboardWithScript;
    ScoreKeeper scoreboard;
    
    //Pause Menu
    public GameObject pauseMenuUI;
    public static bool gameIsPaused;

    void Start()
    {
        scoreboard = scoreboardWithScript.GetComponent<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (scoreboard.playerOneScore > 9)
        {
            playerOneUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (scoreboard.playerTwoScore > 9)
        {
            playerTwoUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (scoreboard.playerThreeScore > 9)
        {
            playerThreeUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (scoreboard.playerFourScore > 9)
        {
            playerFourUI.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    public void Resume()
    {
        FindObjectOfType<AudioManager>().Play("PauseClose");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause()
    {
        FindObjectOfType<AudioManager>().Play("PauseOpen");
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void LoadMenu()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
        gameIsPaused = false;
    }

    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        Application.Quit();
    }

}
