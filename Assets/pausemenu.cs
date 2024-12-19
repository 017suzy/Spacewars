using UnityEngine;

public class pausemenu : MonoBehaviour
{

    private bool isPaused;
    public GameObject pausePanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
    }

    public void ResumeGame() {
        Time.timeScale = 1;
        isPaused = false;
        pausePanel.SetActive(false);
    }
}

