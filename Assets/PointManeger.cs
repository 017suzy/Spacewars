using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PointManeger : MonoBehaviour
{   

    [SerializeField] private FloatSO scoreSO;
    public int score = 0;
    public int highscore = 0;


    public TMP_Text scoreText;
    public TMP_Text highscoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //only in my computer
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "SCORE:" + scoreSO.Value;
        highscoreText.text = "HIGHSCORE:" + highscore.ToString();
    }

    public void UpdateScore(int points){
        scoreSO.Value += points;
        scoreText.text= "SCORE: " + scoreSO.Value;
        if (highscore<score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }

    }
}
