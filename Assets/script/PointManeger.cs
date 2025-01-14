using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PointManeger : MonoBehaviour
{   
    //public int highscore = 0;

    [SerializeField] FloatSO scoreSO;


    public TMP_Text scoreText;
    //public TMP_Text highscoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //only in my computer
        //highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "FINAL SCORE:" + scoreSO.Value;
        //highscoreText.text = "HIGHSCORE:" + highscore.ToString();
    }

    public void UpdateScore(int points){
        scoreSO.Value += points;
        //score += points;
        scoreText.text= "FINAL SCORE: " + scoreSO.Value;
        //if (highscore<score)
        //{
        //    PlayerPrefs.SetInt("highscore", score);
        //}

    }
}
