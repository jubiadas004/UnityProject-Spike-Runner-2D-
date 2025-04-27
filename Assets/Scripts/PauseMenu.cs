using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // added to check for game over
    //private bool isGameOver = false;

   //public GameManagerScript isGameOver;

  // Update is called once per frame
  void Update()
    {
        if (/*!isGameOver &&*/ Input.GetKeyDown(KeyCode.Escape))
        {
          if (GameIsPaused)
          {
            Resume();
          }
          else
          {
            Pause();
          }
        }
    }

    // resume button
    public void Resume()
    {
      pauseMenuUI.SetActive(false);
      Time.timeScale = 1f;          // unfreeze game
      GameIsPaused = false;
    }

    // pause button
    void Pause()
    {
      pauseMenuUI.SetActive(true);    // activate the Pause Menu Screen
      Time.timeScale = 0f;            // Pause the game (freeze game)
      GameIsPaused = true;
    }

    // go to menu screen
    public void LoadMenu()
    {
      Time.timeScale = 1f;
      SceneManager.LoadScene("MainMenu");
    }

    // quit game
    public void QuitGame()
    {
      Application.Quit();
      Debug.Log("Quit");
    }

  // added to check for game over
  /*public void SetGameOver(bool isGameOver)
  {
    this.isGameOver = isGameOver; // Update the game-over state
  }*/
}
