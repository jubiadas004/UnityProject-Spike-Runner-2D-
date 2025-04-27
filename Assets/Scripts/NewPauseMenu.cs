using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewPauseMenu : MonoBehaviour
{
  [SerializeField] GameObject pauseMenu;
    public void Pause()
    {
      pauseMenu.SetActive(true);
      Time.timeScale = 0;
    }

    public void Home()
    {
      SceneManager.LoadScene("Main Menu");
      Time.timeScale = 1;
  }

    public void Resume()
    {
      pauseMenu.SetActive(false);
      Time.timeScale = 1;
    }

    public void Restart()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      Time.timeScale = 1;
      Debug.Log("restart game");
    }

    public void Quit()
    {
      Application.Quit();
      Debug.Log("quit game");
    }


}
