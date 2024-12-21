using TMPro;
using UnityEngine;


namespace Eva.Scoreboard{
    public class ScoreboardUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI entryNameText = null;
        [SerializeField] private TextMeshProUGUI entryScoreText = null;

        public void Initialise(ScoreboardEntry scoreboardEntry)
        {
            entryNameText.text = scoreboardEntry.entryName;
            entryScoreText.text = scoreboardEntry.entryScore.ToString();

        }
    }

}