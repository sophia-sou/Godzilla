using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningMenuScript : MonoBehaviour
{
    private int previousSceneIndex;
    private int nextSceneIndex;

    public void NextLevel()
    {
        previousSceneIndex = PlayerPrefs.GetInt("LastPlayedLevel", 0);
        nextSceneIndex = previousSceneIndex + 1;

        SceneManager.LoadScene(nextSceneIndex); 

        Debug.Log("prev scene is" + previousSceneIndex);
        Debug.Log("next scene is" + nextSceneIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu"); //Go to main menu
    }
}

