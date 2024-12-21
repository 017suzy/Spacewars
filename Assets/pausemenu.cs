using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{

    public nave_atirando ShooterAgent;
    public bool isPaused = false;
    public GameObject pausePanel; //if there was static = you would have to click twice in the button to work (forcing change)

    void Start () {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause")){

            if (isPaused)
            {

                ResumeGame();
            }
            else
            {
                PausedGame();
            }
        }
        
    }

    public void PausedGame(){
        
        pausePanel.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
        ShooterAgent.AllowedToShoot = false;
    }

    public void ResumeGame() {
        
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        ShooterAgent.AllowedToShoot = true;
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f; //make the game unpaused when going back to menu
        SceneManager.LoadScene("MainMenu");
        
    }
}

