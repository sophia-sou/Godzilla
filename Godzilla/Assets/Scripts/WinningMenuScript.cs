using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningMenuScript : MonoBehaviour
{
    private int prevScene = GodzillaHealth.previousSceneIndex;
    private int nextSceneIndex;

    public void NextLevel()
    {
        if (prevScene < 4)
        {
            nextSceneIndex = prevScene + 1;

            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            SceneManager.LoadScene("HighScores");
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu"); //Go to main menu
    }
}

