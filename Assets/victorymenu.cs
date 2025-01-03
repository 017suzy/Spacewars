using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victorymenu : MonoBehaviour
{


    public GameObject VictoryPanel;
    [SerializeField] FloatSO FINALscoreSO;
    public TMP_Text scoreText;
    
    void Start()
    {
        Time.timeScale = 1f;
        scoreText.text = "FINAL SCORE:" + FINALscoreSO.Value;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToTitle()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

}
