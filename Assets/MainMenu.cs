using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("SampleScene");
    }
    public void Credits(){
        SceneManager.LoadScene("Creditos");
    }

    public void BackToMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart(){
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame(){
        Debug.Log("Quitting Game...");
        Application.Quit();

    }
}