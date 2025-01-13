using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victorymenu : MonoBehaviour
{


    public GameObject VictoryPanel;

    public AudioController audioController; // Referência ao AudioController

    public void OnVictory()
    {
        if (audioController != null)
        {
            audioController.PlayVictoryMusic(); // Chama o método no AudioController
        }
        else
        {
            Debug.LogWarning("AudioController não está atribuído no Inspector!");
        }
    }
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