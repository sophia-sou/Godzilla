using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver: MonoBehaviour

{
    private int previousSceneIndex;

    private void Start()
    {
        //int previousSceneIndex = PlayerPrefs.GetInt("PreviousSceneIndex", 0);
        
        previousSceneIndex = PlayerPrefs.GetInt("LastPlayedLevel", 1);

        Debug.Log("you lost and prev scene is" + previousSceneIndex);  
    }

    public void PlayAgain()
    {
        // check if this code line actually leads to the NEXT LEVEL

        SceneManager.LoadScene(previousSceneIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu"); //Go to main menu
    }
}
