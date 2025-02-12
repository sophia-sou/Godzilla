using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using System.Linq;

public static class HighScores
{
    public static string filePath = Application.persistentDataPath + "/highScores.json";

    public static List<HighScoreEntry> bestScores = new List<HighScoreEntry>();
    private static TMP_InputField inputField;
    private static Button submitButton;
    private static GameObject namePanel;
    public static float Score; //= -1f;
    public static float winningTime;


    public static void LoadHighScores()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            ScoreList loadedScores = JsonUtility.FromJson<ScoreList>(json);
            bestScores = loadedScores.scores;

        }
    }

    // Save the high scores to file
    public static void SaveHighScores()
    {
        ScoreList saveData = new ScoreList { scores = bestScores };
        string json = JsonUtility.ToJson(saveData);
        File.WriteAllText(filePath, json);
    }
    public static void SetPendingScore(float score)
    {
        Score = score;
    }


    public static void AddScore(string playerName, float score)
    {
        HighScoreEntry entry = new HighScoreEntry { playerName = playerName, score = score };
        if (!bestScores.Contains(entry))
        {
            bestScores.Add(entry);
            bestScores.Sort((a, b) => b.score.CompareTo(a.score)); // Higher score = better

            if (bestScores.Count > 5)
                bestScores.RemoveAt(bestScores.Count - 1);
        }
    }

    [System.Serializable]
    public class ScoreList
    {
        public List<HighScoreEntry> scores;
    }
    [System.Serializable]
    public class HighScoreEntry
    {
        public string playerName;
        public float score;
    }
}
