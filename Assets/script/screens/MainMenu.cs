using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public FloatValue currentHealth;
    public FloatValue1 currentHealth1;
    public AudioSource audioSource;
    public AudioClip buttonClickSound;

    void Awake()
    {
        Time.timeScale = 1f;
    }
    private void PlayButtonSound()
    {
        if (audioSource != null && buttonClickSound != null)
        {
            audioSource.PlayOneShot(buttonClickSound);
        }
    }

    public void PlayGame()
    {   PlayButtonSound();
        currentHealth.RuntimeValue = currentHealth.initialValue;
        Destroy(GameObject.Find("ScoreKeeper"));
        Destroy(GameObject.Find("HealthCanvas"));
        Destroy(GameObject.Find("HealthCanvasp2"));
        SceneManager.LoadScene("Cutscene");
    }

    public void Credits()
    {   PlayButtonSound();
        Destroy(GameObject.Find("ScoreKeeper"));
        Destroy(GameObject.Find("HealthCanvas"));
        Destroy(GameObject.Find("HealthCanvasp2"));
        SceneManager.LoadScene("Creditos");
    }

    public void BackToMenu()
    {   PlayButtonSound();
        Destroy(GameObject.Find("ScoreKeeper"));
        Destroy(GameObject.Find("HealthCanvas"));
        Destroy(GameObject.Find("HealthCanvasp2"));
        SceneManager.LoadScene("MainMenu");
    }

    public void StartMultiplayer()
    {   PlayButtonSound();
        currentHealth.RuntimeValue = currentHealth.initialValue;
        currentHealth1.RuntimeValue1 = currentHealth1.initialValue1;
        Destroy(GameObject.Find("ScoreKeeper"));
        Destroy(GameObject.Find("HealthCanvas"));
        Destroy(GameObject.Find("HealthCanvasp2"));
        SceneManager.LoadScene("Cutscene2"); 

    }

    public void Restart()
    {   PlayButtonSound();
        currentHealth.RuntimeValue = currentHealth.initialValue;
        SceneManager.LoadScene("singleplayer");
    }

    public void Restartp2()
    {   PlayButtonSound();
        currentHealth.RuntimeValue = currentHealth.initialValue;
        currentHealth1.RuntimeValue1 = currentHealth1.initialValue1;
        SceneManager.LoadScene("multiplayer");
    }

    public void QuitGame()
    {   PlayButtonSound();
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
