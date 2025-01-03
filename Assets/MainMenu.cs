using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public FloatValue currentHealth;
    

    public void PlayGame(){
        currentHealth.RuntimeValue = currentHealth.initialValue;
        Destroy (GameObject.Find("ScoreKeeper")); 
        Destroy (GameObject.Find("HealthCanvas"));  
        SceneManager.LoadScene("Cutscene");
    }
    public void Credits(){
        Destroy (GameObject.Find("ScoreKeeper")); 
        Destroy (GameObject.Find("HealthCanvas"));         
        SceneManager.LoadScene("Creditos");
    }

    public void BackToMenu(){
        Destroy (GameObject.Find("ScoreKeeper")); 
        Destroy (GameObject.Find("HealthCanvas"));       
        SceneManager.LoadScene("MainMenu");

    }

    public void Restart(){
        currentHealth.RuntimeValue = currentHealth.initialValue;       
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame(){
        Debug.Log("Quitting Game...");
        Application.Quit();

    }
}