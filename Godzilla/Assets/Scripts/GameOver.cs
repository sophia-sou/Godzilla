using System.IO;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour

{
    //private int previousSceneIndex;
    private int prevScene = GodzillaHealth.previousSceneIndex;

    public void PlayAgain()
    {
        SceneManager.LoadScene(prevScene);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu"); //Go to main menu
    }

}