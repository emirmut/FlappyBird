using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public string sceneName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSceneChange() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
