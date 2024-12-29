using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class PointManeger : MonoBehaviour
{   
    public int score = 0;
    public int highscore = 0;


    public TMP_Text scoreText;
    public TMP_Text highscoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //only in my computer
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "SCORE:" + score.ToString();
        highscoreText.text = "HIGHSCORE:" + highscore.ToString();
    }

    public void UpdateScore(int points){
        score += points;
        scoreText.text= "SCORE: " + score;
        if (highscore<score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        
        //if (score > 200)
        //    SceneManager.LoadScene("BOSSFIGHT");
    }
}
