using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public FloatValue currentHealth;
    

    public void PlayGame(){
        currentHealth.RuntimeValue = currentHealth.initialValue;
        SceneManager.LoadScene("Cutscene");
    }
    public void Credits(){
        Destroy (GameObject.Find("Canvas"));        
        SceneManager.LoadScene("Creditos");
    }

    public void BackToMenu(){
        Destroy (GameObject.Find("Canvas"));        
        SceneManager.LoadScene("MainMenu");

    }

    public void Restart(){
        currentHealth.RuntimeValue = currentHealth.initialValue;
        Destroy (GameObject.Find("Canvas"));        
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame(){
        Debug.Log("Quitting Game...");
        Application.Quit();

    }
}