using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{

    public bool isPaused = false;
    public GameObject pausePanel;
    public nave_atirando ShooterAgent;
    //public GameObject playerzero;
    public AudioSource resumeAudio; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Input.GetButtonDown("Pause")){

            if (isPaused)
                ResumeGame();
            else
                PausedGame();
        }
        
    }

    [System.Obsolete]
    public void PausedGame(){
        Time.timeScale = 0;

        AudioController[] audios = FindObjectsOfType<AudioController>();
        foreach (AudioController a in audios)
        {
            a.StopBossMusic();
            a.StopPlayMusic();
        }


        isPaused = true;
        pausePanel.SetActive(true);
        ShooterAgent.AllowedToShoot = false;
    }

    [System.Obsolete]
    public void ResumeGame() {
        Time.timeScale = 1f;

        AudioController[] audios = FindObjectsOfType<AudioController>();
        foreach (AudioController a in audios)
        {
            if (SceneManager.GetSceneByName("BOSSFIGHT").isLoaded || (SceneManager.GetSceneByName("BOSSFIGHT2").isLoaded))
            {
                a.PlayBossMusic();
            }
            if (SceneManager.GetSceneByName("singleplayer").isLoaded || (SceneManager.GetSceneByName("multiplayer").isLoaded))
            {
                a.PlayMusic();
            }
            //a.PlayMusic();
        }

        isPaused = false;
        pausePanel.SetActive(false);
        ShooterAgent.AllowedToShoot = true;
        if (resumeAudio != null)
        {
            resumeAudio.Play();
        }
    }


    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

}

