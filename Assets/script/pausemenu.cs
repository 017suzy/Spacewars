using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{

    public bool isPaused = false;
    public GameObject pausePanel;
    public nave_atirando ShooterAgent;
    public GameObject playerzero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause")){

            if (isPaused)
                ResumeGame();
            else
                PausedGame();
        }
        
    }

    public void PausedGame(){
        Time.timeScale = 0;
        isPaused = true;
        pausePanel.SetActive(true);
        ShooterAgent.AllowedToShoot = false;
    }

    public void ResumeGame() {
        Time.timeScale = 1f;
        isPaused = false;
        pausePanel.SetActive(false);
        ShooterAgent.AllowedToShoot = true;
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

}

