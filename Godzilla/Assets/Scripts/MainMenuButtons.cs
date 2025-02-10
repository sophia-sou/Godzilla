using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public string Username;  // �� ����� ��� ������
    public float Score;      // �� ���� ��� ������
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

