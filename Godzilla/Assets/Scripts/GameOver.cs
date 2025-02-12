using System.IO;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
 
{
    public static int killCount=0;
 
    //private int previousSceneIndex;
    private int prevScene = GodzillaHealth.previousSceneIndex;

    public void PlayAgain()
    {
        SceneManager.LoadScene(prevScene);
        if (prevScene==2|| prevScene==3)
        {
            killCount++;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu"); //Go to main menu
    }

}