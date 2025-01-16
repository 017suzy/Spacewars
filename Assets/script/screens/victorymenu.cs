using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victorymenu : MonoBehaviour
{

    /*public AudioController audioController; // Referência ao AudioController
    public AudioSource victoryMusic; // Música de vitória

    public void OnVictory()
    {
        if (audioController != null && victoryMusic != null)
        {
            audioController.PlayVictoryMusic(victoryMusic);
        }
        else
        {
            Debug.LogWarning("AudioController ou VictoryMusic não foi atribuído no Inspector!");
        }
    }*/

    public GameObject VictoryPanel;

    void Start()
    {
        Time.timeScale = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToTitle()
    {
        SceneManager.LoadScene("MainMenu");
    }

}