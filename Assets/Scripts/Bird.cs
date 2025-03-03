using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public float velocity = 3f;
    public bool isDead;
    public Rigidbody2D rb2D;
    public ScoreManager scoreManager;
    public GameObject deathScreen;
    public GameObject pauseButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead) {
            rb2D.linearVelocity = Vector2.up * velocity;
        }
        if (isDead) {
            scoreManager.deathScreen.SetActive(true);
        }
    }

    public void OnTriggerEnter2D(Collider2D collider) { // Unity's built-in function, cannot be called with another name
        if (collider.CompareTag("ScoreDetector")) {
            scoreManager.IncrementScore();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision) { // Unity's built-in function, cannot be called with another name
        if (collision.gameObject.CompareTag("DeathArea")) {
            isDead = true;
            Time.timeScale = 0;
            deathScreen.SetActive(true);
            pauseButton.SetActive(false); // We could have written pauseButton.interactable = false if we wanted to disable the button but keep it visible
            scoreManager.HighScoreDetection();
            scoreManager.MedalDetection();
        }
    }
}
