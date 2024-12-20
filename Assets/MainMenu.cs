using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void Credits(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
    }

    public void BackToMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
    }

    public void QuitGame(){
        Application.Quit();
    }
}
