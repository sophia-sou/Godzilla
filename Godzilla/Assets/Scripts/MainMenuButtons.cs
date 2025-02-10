using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public string Username;  // Το όνομα του παίκτη
    public float Score;      // Το σκορ του παίκτη
    public void PlayGame()
    {
        SceneManager.LoadScene("Level01"); //only used to load level 01
    }
    public void ChooseLevel()
    {
        SceneManager.LoadScene("ChooseLevelScene");
    }

    public void HighScore()
    {
        SceneManager.LoadScene("HighScores");
    }
}

