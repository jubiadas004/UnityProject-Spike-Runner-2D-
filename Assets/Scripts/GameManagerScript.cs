using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {
      //Cursor.visible = false;
     // Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
      /*if (gameOverUI.activeInHierarchy)
      {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
      }
      else
      {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
      }*/
    }

    // activate game over screen
    public void gameOver()
    {
      gameOverUI.SetActive(true);
    }

    // to restart game
    public void restart()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      Debug.Log("Game Restart");
    }

    // redirect to main menu
    public void mainMenu()
    {
      SceneManager.LoadScene("MainMenu");
      Debug.Log("Main Menu");
    }

    // exit game
    public void quit()
    {
      Application.Quit();
      Debug.Log("Quit");
    }
}
