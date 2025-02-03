using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score;
    public Text scoreOnTop;
    public Text scoreInDeathScreen;
    public Text highScoreText;
    int highScore;
    public GameObject deathScreen;
    public GameObject newPrefix;
    public GameObject bronzeMedal;
    public GameObject silverMedal;
    public GameObject goldMedal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        deathScreen.SetActive(false);
        newPrefix.SetActive(false);
        bronzeMedal.SetActive(false);
        silverMedal.SetActive(false);
        goldMedal.SetActive(false);
        score = 0;
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        scoreOnTop.text = score.ToString();
        scoreInDeathScreen.text = score.ToString();
        highScoreText.text = highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        score++;
        scoreOnTop.text = score.ToString();
        scoreInDeathScreen.text = score.ToString();
    }

    public void HighScoreDetection() {
        if (score > highScore) {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            highScoreText.text = highScore.ToString();
            newPrefix.SetActive(true);
        }
    }

    public void MedalDetection() {
        bronzeMedal.SetActive(false);
        silverMedal.SetActive(false);
        goldMedal.SetActive(false);
        if (score >= 1 && score < 10) {
            bronzeMedal.SetActive(true);
        } else if (score >= 10 && score < 20) {
            silverMedal.SetActive(true);
        } else if (score >= 20 && score < 30) {
            goldMedal.SetActive(true);
        }
    }
}
