using UnityEngine;
using TMPro;
public class PointManeger : MonoBehaviour
{   public int score;
    public TMP_Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void UpdateScore(int points){
        score += points;
        scoreText.text= "SCORE: " + score;
    }
}
