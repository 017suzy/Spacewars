using UnityEngine;
using TMPro;
public class PointManeger : MonoBehaviour
{   
    public int score = 0;
    public int highscore = 0;


    public TMP_Text scoreText;
    public TMP_Text highscoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "SCORE:" + score.ToString();
        highscoreText.text = "HIGHSCORE:" + highscore.ToString();
    }

    public void UpdateScore(int points){
        score += points;
<<<<<<< Updated upstream
        scoreText.text= "Pontuaçao: " + score;
=======
        scoreText.text= "SCORE: " + score;
        if (highscore<score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
>>>>>>> Stashed changes
    }
}
