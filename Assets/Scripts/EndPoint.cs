using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
  [SerializeField] bool goNextLevel;
  [SerializeField] string levelName;

  public GameManagerScript gameManager;
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Player"))
    {
      // go to next level
      // SceneController.instance.Nextlevel();
      gameManager.gameOver();
    }
    else
    {
      // SceneController.instance.LoadScene(levelName);
      return;
    }
  }
}
