using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button pauseButton;
    public Sprite paused;
    public Sprite unpaused;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPauseButtonClick() {
        if (pauseButton.image.sprite == paused) {
            Debug.Log("Pause button clicked");
            pauseButton.image.sprite = unpaused;
            Time.timeScale = 1;
        } else if (pauseButton.image.sprite == unpaused) {
            Debug.Log("Unpause button clicked");
            pauseButton.image.sprite = paused;
            Time.timeScale = 0;
        }
    }
}
