using System.IO;
using UnityEngine;

namespace Eva.Scoreboard{
    public class Scoreboard : MonoBehaviour
    {
        [SerializeField] private int maxScoreBoardEntries = 7;
        [SerializeField] private Transform ElementsHighscore = null;
        [SerializeField] private GameObject scoreboardentryobject = null;

        [Header("Test")]
        [SerializeField] ScoreboardEntry testentrydata = new ScoreboardEntry();
        
    }
}
