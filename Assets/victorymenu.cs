using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victorymenu : MonoBehaviour
{


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