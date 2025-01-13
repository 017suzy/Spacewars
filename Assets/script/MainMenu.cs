using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public FloatValue currentHealth;

    void Awake()
    {
        Time.timeScale = 1f;
    }

    public void PlayGame()
    {
        currentHealth.RuntimeValue = currentHealth.initialValue;
        Destroy(GameObject.Find("ScoreKeeper"));
        Destroy(GameObject.Find("HealthCanvas"));
        Destroy(GameObject.Find("HealthCanvasp2"));
        SceneManager.LoadScene("Cutscene");
    }

    public void Credits()
    {
        Destroy(GameObject.Find("ScoreKeeper"));
        Destroy(GameObject.Find("HealthCanvas"));
        Destroy(GameObject.Find("HealthCanvasp2"));
        SceneManager.LoadScene("Creditos");
    }

    public void BackToMenu()
    {
        Destroy(GameObject.Find("ScoreKeeper"));
        Destroy(GameObject.Find("HealthCanvas"));
        Destroy(GameObject.Find("HealthCanvasp2"));
        SceneManager.LoadScene("MainMenu");
    }

    public void StartMultiplayer()
    {
        currentHealth.RuntimeValue = currentHealth.initialValue;
        Destroy(GameObject.Find("ScoreKeeper"));
        Destroy(GameObject.Find("HealthCanvas"));
        Destroy(GameObject.Find("HealthCanvasp2"));
        SceneManager.LoadScene("Cutscene"); 

    }

    public void Restart()
    {
        currentHealth.RuntimeValue = currentHealth.initialValue;
        SceneManager.LoadScene("singleplayer");
    }

    public void Restartp2()
    {
        currentHealth.RuntimeValue = currentHealth.initialValue;
        SceneManager.LoadScene("multiplayer");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
