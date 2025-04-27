using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Vector2 CheckpointPos;
    Rigidbody2D playerRb;

    // for the sound effect
    AudioManager audioManager;
    // for the game over screen
    CameraController cameraController;
    // (public GameManagerScript gameManager;) (Commented out for testing)
    // (private bool isDead;) (Commented out for testing) // to make sure the player is dead

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Debug.Log("Rigidbody2D component on GameController: " + playerRb);
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();  // sound effect
    }

    void Start()
    {
        CheckpointPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle") /*&& !isDead*/)     // isDead is for the game over screen to appear when player dies
        {
            //isDead = true;      // player is dead
            //gameObject.SetActive(false);      // player disappear when player dies
            audioManager.PlaySFX(audioManager.death);   // sound effect for when player dies
            //gameManager.gameOver();
            Die();
        }
    }

    public void UpdateCheckpoint(Vector2 pos)
    {
        CheckpointPos = pos;
    }

    void Die()
    {
        StartCoroutine(Respawn(0.5f));
    }

    IEnumerator Respawn(float duration)
    {
        playerRb.simulated = false;
        playerRb.velocity = new Vector2(0, 0);
        transform.localScale = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(duration);
        transform.position = CheckpointPos;
        transform.localScale = new Vector3(1, 1, 1);
        playerRb.simulated = true;
    }
}
