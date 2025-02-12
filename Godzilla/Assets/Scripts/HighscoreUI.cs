using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class HighScoreUI : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public Button submitButton;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI curScoreText;

    private void Start()
    {
        HighScores.LoadHighScores();
        Debug.Log("HighScoreUI script started.");

        Debug.Log("Current HighScores.Score: " + HighScores.Score);

        if (HighScores.Score > 0) // Only ask for name if a new score exists
        {
            Debug.Log("New score detected, showing name input.");
            nameInputField.gameObject.SetActive(true);
            submitButton.gameObject.SetActive(true);
            submitButton.onClick.AddListener(SubmitScore);
        }
        else
        {

            nameInputField.gameObject.SetActive(false);
            submitButton.gameObject.SetActive(false);
            DisplayHighScores();
        }
    }

    public void SubmitScore()
    {
        string playerName = nameInputField.text;
        Debug.Log($"SubmitScore called! Player: {playerName}, Score: {HighScores.Score}");
        if (!string.IsNullOrEmpty(playerName))
        {
            DisplayCurrentScore();
            HighScores.AddScore(playerName, HighScores.Score);
            HighScores.SaveHighScores();
            nameInputField.gameObject.SetActive(false);
            submitButton.gameObject.SetActive(false);
            
           
            DisplayHighScores();
            Debug.Log(HighScores.bestScores);
        }
        else
        {
            Debug.Log("Please enter a valid name.");
        }
    }

    private void DisplayHighScores()

    {
        highScoreText.text = "High Scores:\n";
        foreach (var entry in HighScores.bestScores)
        {
            highScoreText.text += $"{entry.playerName}: {entry.score:F2} sec\n";
        }
        HighScores.winningTime = 0; // Reset after saving
        Debug.Log(HighScores.Score);
    }
    private void DisplayCurrentScore()
    {
        string playerName = nameInputField.text;
        curScoreText.text = "Current Score: " + playerName + " - " + HighScores.Score.ToString("F2");
    }

    public void MainMenu()
    {
        HighScores.Score = 0;
        SceneManager.LoadScene("StartMenu");
    }

}

